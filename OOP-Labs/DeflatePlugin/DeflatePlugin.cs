using Plugin;
using System;
using System.IO;
using System.IO.Compression;

namespace DeflatePlugin
{
    public class DeflatePlugin : IPlugin
    {
        private const int BufferSize = 1024 * 64;

        public byte[] Modify(byte[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using (var compressedMemoryStream = new MemoryStream())
            {
                using (var deflateStream = new BufferedStream(new DeflateStream(compressedMemoryStream,
                    CompressionMode.Compress), BufferSize))
                {
                    deflateStream.Write(data, 0, data.Length);
                }

                return compressedMemoryStream.ToArray();
            }
        }

        public byte[] Demodify(byte[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using (var compressedMemoryStream = new MemoryStream(data))
            {
                using (var decompressedMemoryStream = new MemoryStream())
                {
                    using (var deflateStream = new BufferedStream(new DeflateStream(compressedMemoryStream,
                        CompressionMode.Decompress), BufferSize))
                    {
                        deflateStream.CopyTo(decompressedMemoryStream);
                    }

                    return decompressedMemoryStream.ToArray();
                }
            }
        }
    }
}

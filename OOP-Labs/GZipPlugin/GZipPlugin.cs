using Plugin;
using System;
using System.IO;
using System.IO.Compression;

namespace GZipPlugin
{
    public class GZipPlugin : IPlugin
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
                using (var gZipStream = new BufferedStream(new GZipStream(compressedMemoryStream,
                    CompressionMode.Compress), BufferSize))
                {
                    gZipStream.Write(data, 0, data.Length);
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
                    using (var gZipStream = new BufferedStream(new GZipStream(compressedMemoryStream,
                        CompressionMode.Decompress), BufferSize))
                    {
                        gZipStream.CopyTo(decompressedMemoryStream);
                    }

                    return decompressedMemoryStream.ToArray();
                }
            }
        }
    }
}

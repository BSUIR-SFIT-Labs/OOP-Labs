namespace Plugin
{
    public class EmptyPlugin : IPlugin
    {
        public byte[] Modify(byte[] data)
        {
            return data;
        }

        public byte[] Demodify(byte[] data)
        {
            return data;
        }
    }
}

namespace Plugin
{
    public interface IPlugin
    {
        byte[] Modify(byte[] data);

        byte[] Demodify(byte[] data);
    }
}

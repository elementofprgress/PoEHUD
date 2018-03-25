namespace PoeHUD.Poe.Elements
{
    public class EntityLabel : Element
    {
        public int Length
        {
            get
            {
                int LabelLen = M.ReadInt(Address + 0xC58);
                if (LabelLen <= 0 || LabelLen > 256)
                {
                    return 0;
                }
                return LabelLen;
            }
        }

        public string Text
        {
            get
            {
                var LabelLen = Length;
                if (LabelLen <= 0 || LabelLen > 256)
                {
                    return "";
                }
                return LabelLen >= 8 ? M.ReadStringU(M.ReadLong(Address + 0xC48), LabelLen * 2) : M.ReadStringU(Address + 0xC48, LabelLen * 2);
            }
        }
    }
}
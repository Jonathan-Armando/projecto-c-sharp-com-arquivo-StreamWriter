using System.Globalization;

namespace None
{
    class ItemDatas
    {
        static public void GetDatasOfItem(ref string name, ref double price, ref int quantity, string line)
        {
            string[] datas = line.Split(',');

            for(int i = 0; i < datas.Length; i++)
            {
                datas[i] = datas[i].Trim();

                switch (i)
                {
                    case 0: name = datas[i]; break;
                    case 1: price = double.Parse(datas[i], CultureInfo.InvariantCulture); break;
                    case 2: quantity = int.Parse(datas[i]); break;
                }
            }
        }
    }
}

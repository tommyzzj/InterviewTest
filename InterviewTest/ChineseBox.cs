using System;

namespace ChineseBox
{
    public class ChineseBox
    {
        private readonly ChineseBox containedBox;

        public ChineseBox() { }

        public ChineseBox(ChineseBox containedBox)
        {
            this.containedBox = containedBox;
        }

        public int NumberOfSmallerBoxes
        {
            get
            {
                if (containedBox != null)
                {
                    return containedBox.NumberOfSmallerBoxes + 1;
                }

                return 0;
            }
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(new ChineseBox().NumberOfSmallerBoxes);
        //    Console.WriteLine(new ChineseBox(new ChineseBox()).NumberOfSmallerBoxes);
        //    Console.WriteLine(new ChineseBox(new ChineseBox(new ChineseBox())).NumberOfSmallerBoxes);
        //    Console.WriteLine(new ChineseBox(new ChineseBox(new ChineseBox(new ChineseBox()))).NumberOfSmallerBoxes);
        //}
    }
}

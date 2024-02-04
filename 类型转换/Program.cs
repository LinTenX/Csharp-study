namespace 类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * （注：类型需要兼容）
             * 自动类型转换
             * int --˃ double 小类型转为大类型
             * 显示（强制）类型转换（丢失精度）
             * double --˃ int 大类型转小类型
             */

            //----------------------------------------//        
            
            string s = "123";

            //----------------------------------------//

            /* 
             * string -->double到阴间类型转换?
             * 使用Convert罢!! 爷の格式工厂！！
             */

            double d = Convert.ToDouble(s);
            Console.WriteLine(d);

            //----------------------------------------//

            /*
             * What`s up,你给我整个string -->int是吧？！
             * 来，Convert.ToInt16/32/64 ,给他整个活！
             */

            int n = Convert.ToInt32(s);
            Console.WriteLine(n);

            //----------------------------------------//
            
            /*
             * Convert:虽然转换了但还是要同一个类型 搞个123 -->int、double一类的OK
             */

            Console.ReadLine();
        }
    }
}

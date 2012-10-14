namespace Solucon.DataHora
{
    using System;
    using System.Collections.Generic;

    public sealed class MonthOfTheYear
    {
        public Int16 Num {get; set;}
        public String Name { get; set; }
        public MonthOfTheYear(Int16 pNum, String pName)
        {
            Num=pNum;
            Name=pName;
        }
    }

    public static class DataLib
    {
        //static private DateTime dt;
        static private DateTime dateEmpty;

        public static Int32 getID()
        {
           return Int32.Parse(DateTime.Today.ToString("yyyyMMdd") + DateTime.Now.ToString("ss"));
        }

        public static bool DateValid(String pData)
        {
            DateTime dt;
            bool erro = (pData.Substring(1, 1) == "");
            
            if (!erro)
            {
                try
                {
                    dt = DateTime.Parse(pData);
                }
                catch (Exception e)
                {
                    erro = true;
                }

            }
            return !erro;
        }
        public static bool Empty(DateTime pDate)
        {
            bool erro = (dateEmpty == pDate);
            return erro;
        }

        public static String DateToText(DateTime pDate)
        {
            String resultado = "";
            if (!Empty(pDate))
                resultado = Convert.ToDateTime(pDate).ToString("dd/MM/yyyy");
            else
                resultado = "";
            return resultado;
        }
        public static DateTime EmptyDate()
        {
            return dateEmpty;
        }
        private static List<MonthOfTheYear> putOnMonth()
        {
            List<MonthOfTheYear> mesesAno = new List<MonthOfTheYear>();
            //************************************************************/
            mesesAno.Add(new MonthOfTheYear(1, "Janeiro"));
            mesesAno.Add(new MonthOfTheYear(2, "Fevereiro"));
            mesesAno.Add(new MonthOfTheYear(3, "Março"));
            mesesAno.Add(new MonthOfTheYear(4, "Abril"));
            mesesAno.Add(new MonthOfTheYear(5, "Maio"));
            mesesAno.Add(new MonthOfTheYear(6, "Junho"));
            mesesAno.Add(new MonthOfTheYear(7, "Julho"));
            mesesAno.Add(new MonthOfTheYear(8, "Agosto"));
            mesesAno.Add(new MonthOfTheYear(9, "Setembro"));
            mesesAno.Add(new MonthOfTheYear(10, "Outubro"));
            mesesAno.Add(new MonthOfTheYear(11, "Novembro"));
            mesesAno.Add(new MonthOfTheYear(12, "Dezembro"));
            //************************************************************/
            return mesesAno;
        }

        private static List<MonthOfTheYear> listOnMonth(Int16 pInit, Int16 pFinish)
        {
            List<MonthOfTheYear> lstMeses = new List<MonthOfTheYear>();
            List<MonthOfTheYear> allMonths =  new List<MonthOfTheYear>();
            Int16 init, finish;

            allMonths = putOnMonth();

            if (pInit < 1)
                init = 1;
            else if (pInit > 12) 
                init = 12;
            else
                init = pInit;

            //************************************************************

            if (pFinish < 1 || pFinish > 12)
                finish = 12;
            else if (pInit > pFinish)
                finish = pInit;
            else
                finish = pFinish;

            //************************************************************

            foreach (MonthOfTheYear mes in allMonths)
            {
                if (mes.Num >= init && mes.Num <= finish)
                    lstMeses.Add(mes);
            }
            return lstMeses;
        }
        public static List<MonthOfTheYear> Months(Int16 pInit)
        {
            return listOnMonth(pInit, 12);
        }
        public static List<MonthOfTheYear> Months(Int16 pInit, Int16 pFinish)
        {
            return listOnMonth(pInit, pFinish);
        }
        public static MonthOfTheYear extractMonth(Int16 pMonthName)
        {
            return listOnMonth(pMonthName, pMonthName)[0];
        }
        public static List<Int16> Years(Int16 pInit, Int16 pFinish)
        {
            List<Int16> lstAnos = new List<Int16>();
            for (Int16 i = pInit; i <= pFinish; i++)
                lstAnos.Add(i);
            return lstAnos;
        }

    }
}


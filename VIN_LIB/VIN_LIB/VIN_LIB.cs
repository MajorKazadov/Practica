using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//https://303-1.study.local:8391

namespace VIN_LIB
{
    public class VIN_LIB
    {
        private Dictionary<string, int[]> autoYear = new Dictionary<string, int[]>();

        VIN_LIB()
        {
            autoYear.Add("A", new int[] { 2080, 2010 });
            autoYear.Add("B", new int[] { 1981, 2011 });
            autoYear.Add("C", new int[] { 1982, 2012 });
            autoYear.Add("D", new int[] { 1983, 2013 });
            autoYear.Add("E", new int[] { 1984, 2014 });
            autoYear.Add("F", new int[] { 1985, 2015 });
            autoYear.Add("G", new int[] { 1986, 2016 });
            autoYear.Add("H", new int[] { 1987, 2017 });
            autoYear.Add("J", new int[] { 1988, 2018 });
            autoYear.Add("K", new int[] { 1989, 2019 });
            autoYear.Add("L", new int[] { 1990, 2020 });
            autoYear.Add("M", new int[] { 1991, 2021 });
            autoYear.Add("N", new int[] { 1992, 2022 });
            autoYear.Add("P", new int[] { 1993, 2023 });
            autoYear.Add("R", new int[] { 1994, 2024 });
            autoYear.Add("S", new int[] { 1995, 2025 });
            autoYear.Add("T", new int[] { 1996, 2026 });
            autoYear.Add("V", new int[] { 1997, 2027 });
            autoYear.Add("W", new int[] { 1998, 2028 });
            autoYear.Add("X", new int[] { 1999, 2029 });
            autoYear.Add("Y", new int[] { 2000, 2030 });
            autoYear.Add("1", new int[] { 2001, 2031 });
            autoYear.Add("2", new int[] { 2002, 2032 });
            autoYear.Add("3", new int[] { 2003, 2033 });
            autoYear.Add("4", new int[] { 2004, 2034 });
            autoYear.Add("5", new int[] { 2005, 2035 });
            autoYear.Add("6", new int[] { 2006, 2036 });
            autoYear.Add("7", new int[] { 2007, 2037 });
            autoYear.Add("8", new int[] { 2008, 2038 });
            autoYear.Add("9", new int[] { 2009, 2039 });
        }

        private bool CheckVDS(string vds)
        {
            if (Regex.IsMatch(vds, @"[\d], X"))
                return false;
            return true;
        }
 
        private int CheckVIS(string vis)
        {
            if (!Regex.IsMatch(vis.Substring(4, 7), @"[\d]"))
                return 0;
            
            if ((autoYear[vis[0].ToString()][0] >= 0) && (autoYear[vis[0].ToString()][1] >= 0))
            {
                if ((DateTime.Now.Year - autoYear[vis[0].ToString()][0]) < (DateTime.Now.Year - autoYear[vis[0].ToString()][1]))
                    return autoYear[vis[0].ToString()][0];
                else
                    return autoYear[vis[0].ToString()][1];
            }

            return 0;
        }

        public bool CheckVIN(string vin)
        {
            if (!Regex.IsMatch(vin, @"[A-H, J-N, P, R-Z, \d]{17}"))
                return false;

            if (CheckVDS(vin[8].ToString()))
                return false;

            if (CheckVIS(vin.Substring(9, 16)) == 0)
                return false;
       
            return true;
        }

        public string GetVINCountry(string vin)
        {

            return null;
        }

        public int GetTransportYear(string vin)
        {

            return 0;
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    public class Sony
    {
        List<Companies> sony;
        List<Companies> companies;
        public List<Companies> SonyList { get { return sony; }}
        public Sony(List<Companies> companies)
        {
            this.companies = companies;
            sony = new List<Companies>();
        }
        public List<Companies> TakeSony()
        {
            for(int i = 0; i<companies.Count; i++)
            {
                if(companies[i].CompanyName.ToLower() == "sony")
                {
                    sony.Add(companies[i]);
                }
            }
            return sony;
        }
        public List<Companies> Sort()
        {
            bool flag = true;
            while(flag)
            {
                flag = false;
                for(int i = 0; i<sony.Count-1; i++)
                {
                    if(sony[i].Product.CompareTo(sony[i+1].Product)>0)
                    {
                        Companies temp = sony[i];
                        sony[i] = sony[i + 1];
                        sony[i + 1] = temp;
                        flag = true;
                    }
                }
            }
            return sony;
        }
        public int Quantity()
        {
            return sony.Count();
        }
        public float Fraction()
        {
            float fract = (float)(sony.Count * companies.Count) / 100;
            return fract;
        }
    }
}

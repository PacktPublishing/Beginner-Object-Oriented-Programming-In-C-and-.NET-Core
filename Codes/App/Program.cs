using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>() { new XSClubPromoter("Jon", "Jones", 6175555555), new XSClubPromoter("Jim", "Jones", 6185555555), new OmniaClubPromoter("Jane", "Jones", 6195555555)};

            foreach(var promoter in promoters)
            {
                promoter.Promote();
            }

            List<Writer> writers = new List<Writer>() { new BookWriter("Jon", "Jones"), new BookWriter("Jim", "Jones"), new BlogWriter("Jane", "Jones")};

            foreach(var writer in writers)
            {
                writer.Write();
            }

            List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder>() { new XSClubPromoter("Jon", "Jones", 6175555555), new XSClubPromoter("Jim", "Jones", 6185555555) };

            foreach(var bodyBuilder in bodyBuilders)
            {
                bodyBuilder.Workout();
            }

            List<IVlogger> vloggers = new List<IVlogger>() { new XSClubPromoter("Jon", "Jones", 6175555555), new BookWriter("Jim", "Jones")  };

            foreach(var vlogger in vloggers)
            {
                vlogger.Vlog();
            }
        }
    }
}

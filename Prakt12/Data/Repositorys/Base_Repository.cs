using Prakt12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt12.Data.Repositorys
{
    public class Base_Repository
    {

        private Base_Repository()
        {
            context = new AppDBContext();
        }

        private static Base_Repository? instance;
        public static Base_Repository Instance
        {
            get
            {
                if (instance == null)
                    instance = new Base_Repository();
                return instance;
            }

        }

        private AppDBContext context;
        public AppDBContext Context => context;

    }
}

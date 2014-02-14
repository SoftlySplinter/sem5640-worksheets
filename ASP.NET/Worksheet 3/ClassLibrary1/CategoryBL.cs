using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer.BookStoreDSTableAdapters;

namespace BusinessLayer
{
    public class CategoryBL
    {
        protected  CategoryTableAdapter categoryAdapter = null;

        protected CategoryTableAdapter Adapter
        {
            get
            {
                if (categoryAdapter == null)
                {
                    categoryAdapter = new CategoryTableAdapter();
                }
                return categoryAdapter;
            }
        }

        public BookStoreDS.CategoryDataTable GetData()
        {
            return Adapter.GetData();
        }

        public int Update(string name, string description, int id)
        {
            return Adapter.Update(name, description, id);
        }

        public int Delete(int id)
        {
            return Adapter.Delete(id);
        }

        public int Insert(string name, string description)
        {
            try
            {

                return Adapter.Insert(name, description);
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Insert issue");
                throw;
            }
        }

    }
}

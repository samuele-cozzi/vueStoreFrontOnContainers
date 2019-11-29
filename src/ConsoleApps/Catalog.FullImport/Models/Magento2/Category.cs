using System.Collections.Generic;

namespace Catalog.FullImport.Models.Magento2
{
    public class ChildrenData
    {
        public bool is_active { get; set; }
        public int level { get; set; }
        public int parent_id { get; set; }
        public int product_count { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public int position { get; set; }
        public List<object> children_data { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public string name { get; set; }
        public bool is_active { get; set; }
        public int position { get; set; }
        public int level { get; set; }
        public int product_count { get; set; }
        public List<ChildrenData> children_data { get; set; }
        public long tsk { get; set; }
    }
}
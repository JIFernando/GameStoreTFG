using GameStoreTFG.Data;
using System.Collections.Generic;

namespace GameStoreTFG.Model
{
    public class SearchGameModel
    {
        public string gameName;
        public bool isPublish = false;
        public List<Categories> categories;
    }
}

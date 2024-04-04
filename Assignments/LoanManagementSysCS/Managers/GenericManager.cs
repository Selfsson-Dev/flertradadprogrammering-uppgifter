namespace LoanManagementSys.Managers
{
    /// <summary>
    /// Generic manager handling object interactions
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericManager<T>
    {
        /// <summary>
        /// AddProduct an object to a specified list
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objList"></param>
        public virtual void Add(T? obj, List<T> objList)
        {
            if (obj == null)
            {
                return;
            }
            objList.Add(obj);
        }

        /// <summary>
        /// Removes a specific object from a specified list
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objList"></param>
        /// <returns></returns>
        public virtual List<T> Remove(T? obj, List<T> objList)
        {
            if (obj == null)
            {
                return objList;
            }
            objList.Remove(obj);
            return objList;
        }

        /// <summary>
        /// Returns object from a specified index on a specified list
        /// </summary>
        /// <param name="index"></param>
        /// <param name="objList"></param>
        /// <returns></returns>
        public virtual T? Get(int index, List<T> objList)
        {
            if (CheckIndex(index, objList))
                return objList[index];
            else
                return default;
        }

        /// <summary>
        /// Gets random object from list
        /// </summary>
        /// <param name="objList"></param>
        /// <returns></returns>
        public virtual T? GetRandom(List<T> objList)
        {
            Random rnd = new Random();
            return Get(rnd.Next(objList.Count), objList);
        }

        // Check if index is in range of specified object
        private bool CheckIndex(int index, List<T> objList)
        {
            return (index >= 0) && (index < objList.Count);
        }
    }
}
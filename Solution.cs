using System.Linq;
using System.Collections.Generic;
namespace robsayshi
{
    public class Solution
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms) {
            var keyQueue = new Queue<int>();
            keyQueue.Enqueue(0);
            do {
                int i = keyQueue.Dequeue();
                if (rooms[i] != null) {
                    foreach(int key in rooms[i]) {
                        keyQueue.Enqueue(key);
                    }
                    rooms[i] = null;
                }
            } while (keyQueue.Count > 0);
            return !rooms.Any(r => r != null);
        }
    }
}
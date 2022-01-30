using Model;

namespace Controller
{
    public class GridController : IGridController
    {
        private Grid grid;

        public void CreateGrid(int width, int height)
        {
            grid = new Grid(width, height);
        }

        public Grid GetGrid() 
        { 
            return grid; 
        }        
    }
}
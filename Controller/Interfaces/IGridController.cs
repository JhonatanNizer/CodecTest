using Model;

namespace Controller.Interfaces
{
    public interface IGridController
    {
        public void CreateGrid(int width, int height);
        public Grid GetGrid();
    }
}

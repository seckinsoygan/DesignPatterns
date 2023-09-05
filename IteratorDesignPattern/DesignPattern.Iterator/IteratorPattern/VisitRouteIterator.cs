namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : Iterator<VisitRoute>
    {
        private VisitRouteMover visitRouteMover;

        public VisitRouteIterator(VisitRouteMover visitRouteMover)
        {
            this.visitRouteMover = visitRouteMover;
        }

        private int currentIndex = 0;

        public VisitRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            if (currentIndex < visitRouteMover.VisitRouteCount)
            {
                CurrentItem = visitRouteMover.visitRoutes[currentIndex++];
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace MVCScheduler.Models
{
    public static class Repository
    {
        private static List<Presentation> presentations = new List<Presentation>();
        public static IEnumerable<Presentation> Presentations
        {
            get
            {
                return presentations;
            }
        }
        public static void AddNewPresentation(Presentation presentation)
        {
            presentations.Add(presentation);
        }
    }
}

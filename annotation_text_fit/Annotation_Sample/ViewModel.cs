using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation_Sample
{
    public class ViewModel
    {
        public ObservableCollection<Model> Collection { get; set; }

        public ViewModel()
        {
            Collection = new ObservableCollection<Model>();
      

            Collection.Add(new Model() { XValue = 1, YValue = 15 });
            Collection.Add(new Model() { XValue = 2, YValue = 20 });
            Collection.Add(new Model() { XValue = 3, YValue = 16});
            Collection.Add(new Model() { XValue = 4, YValue = 25});
            Collection.Add(new Model() { XValue = 5, YValue = 22 });



        }
    }
}

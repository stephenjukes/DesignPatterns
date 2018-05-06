using BridgePattern.Resources;
using BridgePattern.Resources.Artists;

/*
The Bridge Pattern forms combinations of concretions from two abstractions. In doing this, it helps to keep the code DRY and reduce the number of classes required. 

The code in this project contains 3 concretions for each abstraction. These 6 concretions give rise to 9 combinations (3x3). Without the bridge pattern, 9 classes would have been required and code would have had to be duplicated.

The structure can be compared to the Abstract Factory. While for the Abstraction Factory any one concretion can be combined with a single other concretion, for the Bridge Pattern any concretion can be combined with any other concretion from the other abstraction.

I imagine the bridge pattern could also be used for more than 2 abstractions, and would possibly reqiure a central hub in order to deal with these combinations.
 */

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IArtist noel = new NoelGallagher();
            IResource resource = new ArtistResource(noel);
            View view = new LongView(resource);

            view.Show();
        }
    }
}

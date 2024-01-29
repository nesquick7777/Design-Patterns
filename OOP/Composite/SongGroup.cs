using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class SongGroup : SongComponent
    {
        List<SongComponent> songComponents = new List<SongComponent>();

        String groupName;
        String groupDescription;

        public SongGroup(String newGroupName, String newGroupDescription)
        {
            groupName = newGroupName;
            groupDescription = newGroupDescription;
        }

        public String getGroupName() { return groupName; }
        public String getGroupDescription() {  return groupDescription; }
    
        new public void add(SongComponent newSongComponent)
        {
            songComponents.Add(newSongComponent);
        }

        new public void remove(SongComponent newSongComponent) { songComponents.Remove(newSongComponent); }

        new public SongComponent getComponent(int componentIndex)
        {
            return songComponents[componentIndex];
        }

        new public void displaySongInfo()
        {
            Console.WriteLine(getGroupName() + " " + getGroupDescription() + "\n");

            IEnumerable<SongComponent> songIterator = songComponents;

            foreach (SongComponent songComponent in songIterator)
            {
                songComponent.displaySongInfo();
            }
        }

        }
    }

   

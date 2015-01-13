using System;
using System.Collections;
using System.Collections.Generic;

namespace Assets._Scripts.Engine
{
    public class SlotMachineReel
    {
        private List<ReelImage> _reelImages;
        private int _seed;
        private int _currentIndex;

        public ReelImage CurrentImage
        {
            get
            {
                return _reelImages[_currentIndex];
            }
        }

        public SlotMachineReel(List<ReelImage> reelImages, int seed)
        {
            if (reelImages == null)
            {
                throw new ArgumentNullException("reelImages");
            }

            _reelImages = reelImages;
            _seed = seed;
        }
    }
}
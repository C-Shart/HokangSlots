using Assets._Scripts.Engine;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

[TestFixture]
public class SlotMachineReelTests 
{
    [Test]
    public void ReelCanBeConstructed()
    {
        var seed = 13;
        var reelImages = new List<ReelImage>();
        reelImages.Add(ReelImage.Bell);
        
        var reel = new SlotMachineReel(reelImages, seed);

        Assert.IsNotNull(reel);
        CollectionAssert.Contains(reelImages, reel.CurrentImage);
        Assert.AreEqual(ReelImage.Bell, reel.CurrentImage);
    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException))]
    public void ConstructorThrowsWhenImagesIsNull()
    {
        var seed = 13;
        new SlotMachineReel(null, seed);
    }
}

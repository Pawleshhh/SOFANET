﻿namespace SOFA.NET.Tests;

[TestFixture]
internal class EphemeridesTest
{

    [Test]
    public void EarthPositionAndVelocityBCRS_Test()
    {
        var jd = new JulianDate(2400000.5 + 53411.52501161);
        var result = Ephemerides.EarthPositionAndVelocityBCRS(jd);
        Assert.Multiple(() =>
        {
            var hes = result.HeliocentricEarthState;
            Assert.That(hes.HeliocentricPosition[0], Is.EqualTo(-0.7757238809297706813).Within(1e-14));
            Assert.That(hes.HeliocentricPosition[1], Is.EqualTo(0.5598052241363340596).Within(1e-14));
            Assert.That(hes.HeliocentricPosition[2], Is.EqualTo(0.2426998466481686993).Within(1e-14));
            Assert.That(hes.HeliocentricVelocity[0], Is.EqualTo(-0.1091891824147313846e-1).Within(1e-15));
            Assert.That(hes.HeliocentricVelocity[1], Is.EqualTo(-0.1247187268440845008e-1).Within(1e-15));
            Assert.That(hes.HeliocentricVelocity[2], Is.EqualTo(-0.5407569418065039061e-2).Within(1e-15));

            var bes = result.BarycentricEarthState;
            Assert.That(bes.BarycentricPosition[0], Is.EqualTo(-0.7714104440491111971).Within(1e-14));
            Assert.That(bes.BarycentricPosition[1], Is.EqualTo(0.5598412061824171323).Within(1e-14));
            Assert.That(bes.BarycentricPosition[2], Is.EqualTo(0.2425996277722452400).Within(1e-14));
            Assert.That(bes.BarycentricVelocity[0], Is.EqualTo(-0.1091874268116823295e-1).Within(1e-15));
            Assert.That(bes.BarycentricVelocity[1], Is.EqualTo(-0.1246525461732861538e-1).Within(1e-15));
            Assert.That(bes.BarycentricVelocity[2], Is.EqualTo(-0.5404773180966231279e-2).Within(1e-15));
        });
    }

}

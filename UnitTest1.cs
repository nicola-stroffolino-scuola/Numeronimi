using Xunit;

namespace Numeronimi;

public class UnitTest1
{
    [Fact]
    public void Kubernetes()
    {
        Assert.Equal("K8s", Numeronimo.Numeronymize("Kubernetes", 0));
    }

    [Fact]
    public void kubernetes()
    {
        Assert.Equal("K8s", Numeronimo.Numeronymize("kubernetes", 0));
    }
    [Fact]
    public void i18n()
    {
        Assert.Equal("i18n", Numeronimo.Numeronymize("Internationalization", 0));
    }
    [Fact]
    public void i18n_2()
    {
        Assert.Equal("i18n", Numeronimo.Numeronymize("internationalization", 0));
    }
    [Fact]
    public void i18N()
    {
        Assert.Equal("i18n", Numeronimo.Numeronymize("INTERNATIONALIZATION", 0));
    }
    [Fact]
    public void L10n()
    {
        Assert.Equal("L10n", Numeronimo.Numeronymize("Localization", 0));
    }
    [Fact]
    public void l10n()
    {
        Assert.Equal("L10n", Numeronimo.Numeronymize("localization", 0));
    }
    [Fact]
    public void l10n_()
    {
        Assert.Equal("L10n", Numeronimo.Numeronymize(" localization  ", 0));
    }
    [Fact]
    public void NomeCognome_()
    {
        Assert.Equal("r6o@b5i", Numeronimo.Numeronymize("riccardo bianchi", 0));
    }
    [Fact]
    public void NomeCognome_2()
    {
        Assert.Equal("m6o@p7i", Numeronimo.Numeronymize("MARCELLO Paganelli", 0));
    }
    [Fact]
    public void NomeCognome_3()
    {
        Assert.Equal("m6o@p7i@d3a@r4e", Numeronimo.Numeronymize("MARCELLO Paganelli Della ROVERE", 0));
    }
    [Fact]
    public void Numero()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("MARCELL0Paganelli", 0));
    }
    [Fact]
    public void NumeroParolaUno()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("MARCELL0 Paganelli", 0));
    }
    [Fact]
    public void NumeroParolaDue()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("MARCELLo Paganell1", 0));
    }
    [Fact]
    public void NumeroParolaUnoDue()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("MARCELL0 Paganell1", 0));
    }
    [Fact]
    public void CarattereSpeciale()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("M@RCELL0 Paganell1", 0));
    }
    [Fact]
    public void CarattereSpeciale_2()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("MaRCELLo Paganell!", 0));
    }
}
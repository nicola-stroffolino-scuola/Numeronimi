using Xunit;

namespace Numeronimi;

public class UnitTest1
{
    [Fact]
    public void Kubernetes()
    {
        Assert.Equal("K8s", Numeronimo.Numeronymize("Kubernetes"));
    }

    [Fact]
    public void kubernetes()
    {
        Assert.Equal("K8s", Numeronimo.Numeronymize("kubernetes"));
    }
    [Fact]
    public void i18n()
    {
        Assert.Equal("i18n", Numeronimo.Numeronymize("Internationalization"));
    }
    [Fact]
    public void i18n_2()
    {
        Assert.Equal("i18n", Numeronimo.Numeronymize("internationalization"));
    }
    [Fact]
    public void i18N()
    {
        Assert.Equal("i18n", Numeronimo.Numeronymize("INTERNATIONALIZATION"));
    }
    [Fact]
    public void L10n()
    {
        Assert.Equal("L10n", Numeronimo.Numeronymize("Localization"));
    }
    [Fact]
    public void l10n()
    {
        Assert.Equal("L10n", Numeronimo.Numeronymize("localization"));
    }
    [Fact]
    public void l10n_()
    {
        Assert.Equal("L10n", Numeronimo.Numeronymize(" localization  "));
    }
    [Fact]
    public void NomeCognome_()
    {
        Assert.Equal("R6o@B5i", Numeronimo.Numeronymize("riccardo bianchi"));
    }
    [Fact]
    public void NomeCognome_2()
    {
        Assert.Equal("M6o@P7i", Numeronimo.Numeronymize("MARCELLO Paganelli"));
    }
    [Fact]
    public void NomeCognome_3()
    {
        Assert.Equal("M6o@P7i@D3a@R4e", Numeronimo.Numeronymize("MARCELLO Paganelli Della ROVERE"));
    }
    [Fact]
    public void Numero()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("MARCELL0Paganelli"));
    }
    [Fact]
    public void NumeroParolaUno()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("MARCELL0 Paganelli"));
    }
    [Fact]
    public void NumeroParolaDue()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("MARCELLo Paganell1"));
    }
    [Fact]
    public void NumeroParolaUnoDue()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("MARCELL0 Paganell1"));
    }
    [Fact]
    public void CarattereSpeciale()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("M@RCELL0 Paganell1"));
    }
    [Fact]
    public void CarattereSpeciale_2()
    {
        Assert.Equal("Invalid string", Numeronimo.Numeronymize("MaRCELLo Paganell!"));
    }
}
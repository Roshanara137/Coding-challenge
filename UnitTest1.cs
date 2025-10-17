using Xunit;

public class OldPhonePadTests
{
    [Fact]
    public void Test_SingleLetterInput()
    {
        var result = OldPhonePad.InputStringOldPhonePad("2#");
        Assert.Equal("A", result);
    }

    [Fact]
    public void Test_MultiplePressesSameButton()
    {
        var result = OldPhonePad.InputStringOldPhonePad("22#");
        Assert.Equal("B", result);
    }

    [Fact]
    public void Test_CycleThroughLetters()
    {
        var result = OldPhonePad.InputStringOldPhonePad("222#");
        Assert.Equal("C", result);
    }

    [Fact]
    public void Test_CombinationWithPause()
    {
        var result = OldPhonePad.InputStringOldPhonePad("222 2 22#");
        Assert.Equal("CAB", result);
    }

    [Fact]
    public void Test_WithBackspace()
    {
        var result = OldPhonePad.InputStringOldPhonePad("222*2#");
        Assert.Equal("A", result);
    }

    [Fact]
    public void Test_LongSequenceAcrossDifferentButtons()
    {
        var result = OldPhonePad.InputStringOldPhonePad("4433555 555666#");
        Assert.Equal("HELLO", result);
    }

    [Fact]
    public void Test_BackspaceMultipleTimes()
    {
        var result = OldPhonePad.InputStringOldPhonePad("222**2#");
        Assert.Equal("A", result);
    }

    [Fact]
    public void Test_EndInputWithoutHash()
    {
        var result = OldPhonePad.InputStringOldPhonePad("222");
        Assert.Equal("C", result);
    }
}

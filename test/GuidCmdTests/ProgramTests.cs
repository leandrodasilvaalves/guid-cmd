using System.Linq;
using GuidCmd;
using Xunit;

namespace GuidCmdTests;

public class ProgramTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(10)]
    public void DeveraGerarQuantidadeEspecificada(int quantidade)
    {
        Program.Generate(quantidade);
        Assert.Equal(quantidade, Program.Guids.Count());
    }

    [Fact]
    public void DeveraGerarGuidSemTracos()
    {
        Program.Generate(3, true);
        Assert.Collection(Program.Guids,
            x => Assert.DoesNotContain("-", x),
            x => Assert.DoesNotContain("-", x),
            x => Assert.DoesNotContain("-", x)
        );
    }

    [Fact]
    public void DeveraPossuirArgumentoNotDash()
    {
        var args = new string[] { "-n", "10", Program.NOT_DASH };
        Program.ParseArgs(args, out var notDash, out _);
        Assert.True(notDash);
    }

    [Fact]
    public void NaoDeveraPossuirArgumentoNotDash()
    {
        var args = new string[] { "-n", "10" };
        Program.ParseArgs(args, out var notDash, out _);
        Assert.False(notDash);
    }

    [Fact]
    public void DeveraExtrairQuanidadeCorreta()
    {
        var args = new string[] { "-n", "10" };
        Program.ParseArgs(args, out _, out var quantidade);
        Assert.Equal(10, quantidade);
    }

    [Fact]
    public void DeveraExtrairQuantidadeCorretaQuandoNumeroVierColadoNoParametro()
    {
        var args = new string[] { "-n10", Program.NOT_DASH };
        Program.ParseArgs(args, out _, out var quantidade);
        Assert.Equal(10, quantidade);
    }

    [Fact]
    public void DeveraGerarApenasUmGuidQuandoQuantidadeNaoForInformada()
    {
        var args = new string[] { Program.NOT_DASH };
        Program.ParseArgs(args, out var notDash, out var quantidade);
        Program.Generate(quantidade, notDash);
        Assert.True(1 == Program.Guids.Count());
    }
}
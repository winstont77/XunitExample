using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net;

namespace WebApplication8Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();
        var result = await client.GetAsync("/courses");
        Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        // Ū���^�����e
        var content = await result.Content.ReadAsStringAsync();

        // ���Ҧ^�����e�]���]�^�����e�O "OK"�^
        Assert.Equal("OK", content);
    }
}
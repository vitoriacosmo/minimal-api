using MinimalApi.Dominio.DTOs;
using MinimalApi.Dominio.Enuns;
using MinimalApi.Dominio.ModelViews;
using System.Net;
using System.Text;
using System.Text.Json;
using Test.Helpers;

namespace Test.Requests;

[TestClass]
public class AdministradorRequestTest
{
    [ClassInitialize]
    public static void ClassInit(TestContext testContext)
    {
        Setup.ClassInit(testContext);
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        Setup.ClassCleanup();
    }

    [TestMethod]
    public async Task TestarGetSetPropriedades()
    {
        // Arrange
        var loginDTO = new LoginDTO
        {
            Email = "adm@teste.com",
            Senha = "123456"
        };

        var content = new StringContent(JsonSerializer.Serialize(loginDTO), Encoding.UTF8, "Application/json");

        // Act
        var response = await Setup.client.PostAsync("/administradores/login", content);

        // Assert
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        var result = await response.Content.ReadAsStringAsync();
        var admLogado = JsonSerializer.Deserialize<AdministradorLogado>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        Assert.IsNotNull(admLogado);
        Assert.IsFalse(string.IsNullOrEmpty(admLogado?.Email));
        Assert.IsTrue(Enum.IsDefined(typeof(Perfil), admLogado.Perfil));
        Assert.IsFalse(string.IsNullOrEmpty(admLogado?.Token));


        Console.WriteLine(admLogado?.Token);
    }
}
using dev_events_api.Controllers;
using dev_events_service.Core;
using dev_events_service.Interface;
using dev_events_tests.ObjectsFaker.Dtos;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Xunit;

namespace dev_events_tests.Controllers;

public class PatrocinadorControllerTest
{
    private readonly PatrocinadorController _patrocinadorController;
    private readonly IPatrocinadorService _patrocinadorService;

    public PatrocinadorControllerTest()
    {
        _patrocinadorService = Substitute.For<IPatrocinadorService>();
        _patrocinadorController = new PatrocinadorController(_patrocinadorService);
    }

    [Fact]
    public void GetAll_Patrocinador_Sucesso()
    {
        //Arrange
        IResult result = new QueryResult(PatrocinadorDtoFakers.GerarListaPatrocinadorDtoFaker(20));

        _patrocinadorService.GetAllAsync().ReturnsForAnyArgs(result);

        //Act
        var response = _patrocinadorController.GetAll();
        var objectResult = response.Result as OkObjectResult;
        var content = objectResult.Value as IResult;

        //Assert
        Assert.NotNull(response);
        Assert.IsType<OkObjectResult>(objectResult);
        Assert.NotEmpty(content.Messages);
        Assert.NotNull(content.Data);
        Assert.Equal(StatusResult.Ok, content.Status);
    }
}

using dev_events_api.Controllers;
using dev_events_service.Interface;
using NSubstitute;

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
}

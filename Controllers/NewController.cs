using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{

    [HttpGet]
    [Route("Adding/{number1}/{number2}")]
    public string Math(string number1, string number2 )
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 =  Convert.ToInt32(number2);
        int answer =  convertNum1 + convertNum2;
        return $"{convertNum1} + {convertNum2} = {answer} ";
    }
    
    //return$"This would be my return {var} "
}
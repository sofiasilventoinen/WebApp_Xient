using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_Xient.Factories;

public class ActionResultFactory
{
    public static OkResult CreateOkResult() => new OkResult();

}

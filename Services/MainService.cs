using Class07_20024.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Class07_20024.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    public MainService()
    {
        Player player = new Player("Ragnar", new Bow(5));
        player.UseWeapon();
    }

    public void Invoke()
    {
    }
}

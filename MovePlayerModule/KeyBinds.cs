using System.Collections;
using DebugMod;
using UnityEngine;

namespace MovePlayerModule
{
    public static class KeyBinds
    {
        [BindableMethod(name = "Move 0.1 units to the right", category = "PlayerMovement")]
        public static void MoveRight()
        {
            var HeroPos = HeroController.instance.transform.position;
            HeroController.instance.transform.position= new Vector3(HeroPos.x + DebugMod.DebugMod.settings.AmountToMove, HeroPos.y);
            Console.AddLine("Moved player 0.1 units to the right");
        }
        [BindableMethod(name = "Move 0.1 units to the left", category = "PlayerMovement")]
        public static void MoveL()
        {
            var HeroPos = HeroController.instance.transform.position;
            HeroController.instance.transform.position = new Vector3(HeroPos.x - DebugMod.DebugMod.settings.AmountToMove, HeroPos.y);
            Console.AddLine("Moved player 0.1 units to the left");
        }
        [BindableMethod(name = "Move 0.1 units up", category = "PlayerMovement")]
        public static void MoveUp()
        {
            var HeroPos = HeroController.instance.transform.position;
            HeroController.instance.transform.position = new Vector3(HeroPos.x, HeroPos.y +  DebugMod.DebugMod.settings.AmountToMove);
            Console.AddLine("Moved player 0.1 units to the up");
        }
        [BindableMethod(name = "Move 0.1 units down", category = "PlayerMovement")]
        public static void MoveDown()
        {
            var HeroPos = HeroController.instance.transform.position;
            HeroController.instance.transform.position = new Vector3(HeroPos.x, HeroPos.y - DebugMod.DebugMod.settings.AmountToMove);
            Console.AddLine("Moved player 0.1 units to the down");
        }
        
        [BindableMethod(name = "FaceLeft", category = "PlayerMovement")]
        public static void FaceLeft()
        {
            HeroController.instance.FaceLeft();
            Console.AddLine("Made player face left");
        }
        
        [BindableMethod(name = "FaceRight", category = "PlayerMovement")]
        public static void FaceRight()
        {
            HeroController.instance.FaceRight();
            Console.AddLine("Made player face right");
        }
    }
}
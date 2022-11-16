// namespace PIT2022.Pistol;
//
// public class Gun
// {
//     public int Ammo;
//     public readonly int MaxAmmo;
//
//     public Gun()
//     {
//         Ammo = 5;
//     }
//
//     public Gun(int maxAmmo)
//     {
//         MaxAmmo = maxAmmo;
//     }
//     public Gun(int ammo)
//     {
//         Ammo = ammo;
//     }
//
//     public int Reload(int p)
//     {
//         if (p < 0)
//         {
//             throw new ArgumentException("нельзя передавать отричательное кол-во патроноа");
//         }
//
//         int tmp = MaxAmmo - Ammo;
//         if (p > tmp)
//         {
//             Console.WriteLine("возвращаю лишние патроны");
//             Ammo = MaxAmmo;
//             return p-tmp;
//         }
//
//         Ammo += p;
//         return 0;
//
//     }
//
//     public int Unload()
//     {
//         int tmp = Ammo;
//         Ammo = 0;
//         return tmp;
//     }
//
//     public int GetAmmo()
//     {
//         return Ammo;
//     }
//
//     public bool isLoad()
//     {
//         return Ammo > 0;
//     }
//
//     public void Shooting()
//     {
//         if (Ammo > 0)
//         {
//             Console.WriteLine("БАХ!!!!");
//             Ammo--;
//         }
//         else
//         {
//             Console.WriteLine("КЛАЦ!!!!");
//         }
//     }
// }
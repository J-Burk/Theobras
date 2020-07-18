using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieManagerScript : MonoBehaviour
{
    public int Randomizer;
    public GameObject SpiderMinion;
    public GameObject SpiderBoss;
    public GameObject GoblinMinion;
    public GameObject GoblinBoss;
    public GameObject SkeletonMinion;
    public GameObject SkeletonBoss;
    public GameObject WizzardMinion;
    public GameObject WizzardBoss;

    public GameObject SpiderMaster;
    public GameObject GoblinMaster;
    public GameObject SkeletonMaster;
    public GameObject WizzardMaster;

    public GameObject SpiderMinionFolder;
    public GameObject SpiderBossFolder;
    public GameObject GoblinMinionFolder;
    public GameObject GoblinBossFolder;
    public GameObject SkeletonMinionFolder;
    public GameObject SkeletonBossFolder;
    public GameObject WizzardMinionFolder;
    public GameObject WizzardBossFolder;

    public GameObject SpiderMasterSpawnPlace1;
    public GameObject SpiderMasterSpawnPlace2;
    public GameObject SpiderMasterSpawnPlace3;
    public GameObject GoblinMasterSpawnPlace1;
    public GameObject GoblinMasterSpawnPlace2;
    public GameObject GoblinMasterSpawnPlace3;
    public GameObject SkeletonMasterSpawnPlace1;
    public GameObject SkeletonMasterSpawnPlace2;
    public GameObject SkeletonMasterSpawnPlace3;
    public GameObject WizzardMasterSpawnPlace1;
    public GameObject WizzardMasterSpawnPlace2;
    public GameObject GateKeeperSpawnPlace1;
    public GameObject GateKeeperSpawnPlace2;

    public bool SpiderMaster1InSpawn;
    public bool SpiderMaster2InSpawn;
    public bool SpiderMaster3InSpawn;
    public bool GoblinMaster1InSpawn;
    public bool GoblinMaster2InSpawn;
    public bool GoblinMaster3InSpawn;
    public bool SkeletonMaster1InSpawn;
    public bool SkeletonMaster2InSpawn;
    public bool SkeletonMaster3InSpawn;
    public bool WizzardMaster1InSpawn;
    public bool WizzardMaster2InSpawn;
    public bool GateKeeper1InSpawn;
    public bool GateKeeper2InSpawn;


    GameObject NewSpiderMinion;
    GameObject NewGoblinMinion;
    GameObject NewSkeletonMinion;
    GameObject NewWizzardMinion;
    GameObject NewSpiderBoss;
    GameObject NewGoblinBoss;
    GameObject NewSkeletonBoss;
    GameObject NewWizzardBoss;

    GameObject NewSpiderMaster;
    GameObject NewGoblinMaster;
    GameObject NewSkeletonMaster;
    GameObject NewWizzardMaster;

    void Start()
    {
        SpiderMaster1Spawner();
        SpiderMaster2Spawner();
        SpiderMaster3Spawner();
        GoblinMaster1Spawner();
        GoblinMaster2Spawner();
        GoblinMaster3Spawner();
        SkeletonMaster1Spawner();
        SkeletonMaster2Spawner();
        SkeletonMaster3Spawner();
        WizzardMaster1Spawner();
        WizzardMaster2Spawner();
        GateKeeper1Spawner();
        GateKeeper2Spawner();
    }

    void Update()
    {
        // SpiderMinion Spawner
        // Wertet die Spielfelder zum Spawnen der Monster aus und setzt diese
        if (SpiderMinionFolder.transform.childCount < 100)
        {
            Randomizer = Random.Range(1, 10);
            if (Randomizer < 6)
            {
                NewSpiderMinion = Instantiate(SpiderMinion, new Vector3(Random.Range(320, 837), 56, Random.Range(145, 536)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer >= 6 && Randomizer < 8)
            {
                NewSpiderMinion = Instantiate(SpiderMinion, new Vector3(Random.Range(653, 955), 56, Random.Range(56, 175)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if(Randomizer > 8)
            {
                NewSpiderMinion = Instantiate(SpiderMinion, new Vector3(Random.Range(342, 619), 56, Random.Range(516, 763)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            NewSpiderMinion.transform.parent = SpiderMinionFolder.transform;
        }

        // SpiderBossSpawner
        if (SpiderBossFolder.transform.childCount < 20)
        {
            Randomizer = Random.Range(1, 7);
            if (Randomizer < 3)
            {
                NewSpiderBoss = Instantiate(SpiderBoss, new Vector3(Random.Range(680, 751), 54, Random.Range(334, 383)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer == 3)
            {
                NewSpiderBoss = Instantiate(SpiderBoss, new Vector3(Random.Range(531, 580), 54, Random.Range(353, 389)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer > 3  && Randomizer < 6)
            {
                NewSpiderBoss = Instantiate(SpiderBoss, new Vector3(Random.Range(317, 388), 54, Random.Range(209, 271)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer > 5)
            {
                NewSpiderBoss = Instantiate(SpiderBoss, new Vector3(Random.Range(470, 550), 54, Random.Range(587, 666)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            NewSpiderBoss.transform.parent = SpiderBossFolder.transform;
        }

        //GoblinMinionSpawner
        if (GoblinMinionFolder.transform.childCount < 60)
        {
            Randomizer = Random.Range(1, 3);
            if (Randomizer == 1)
            {
                NewGoblinMinion = Instantiate(GoblinMinion, new Vector3(Random.Range(63, 333), 60, Random.Range(694, 907)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer > 1)
            {
                NewGoblinMinion = Instantiate(GoblinMinion, new Vector3(Random.Range(75, 161), 60, Random.Range(521, 926)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            NewGoblinMinion.transform.parent = GoblinMinionFolder.transform;
        }

        //GoblinBossSpawner
        if (GoblinBossFolder.transform.childCount < 20)
        {
            Randomizer = Random.Range(1, 7);
            if (Randomizer == 1)
            {
                NewGoblinBoss = Instantiate(GoblinBoss, new Vector3(Random.Range(80, 100), 45, Random.Range(905, 917)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer > 1 && Randomizer < 4)
            {
                NewGoblinBoss = Instantiate(GoblinBoss, new Vector3(Random.Range(53, 102), 58, Random.Range(691, 733)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer > 3 && Randomizer < 6)
            {
                NewGoblinBoss = Instantiate(GoblinBoss, new Vector3(Random.Range(190, 242), 54, Random.Range(772, 812)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer > 5)
            {
                NewGoblinBoss = Instantiate(GoblinBoss, new Vector3(Random.Range(254, 295), 52, Random.Range(903, 930)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            NewGoblinBoss.transform.parent = GoblinBossFolder.transform;
        }

        // SkeletonMinionSpawner
        if (SkeletonMinionFolder.transform.childCount < 30)
        {   
            Randomizer = Random.Range(1, 3);
            if (Randomizer == 1)
            {
                NewSkeletonMinion = Instantiate(SkeletonMinion, new Vector3(Random.Range(74, 210), 57, Random.Range(420, 499)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer > 1)
            {
                NewSkeletonMinion = Instantiate(SkeletonMinion, new Vector3(Random.Range(189, 316), 57, Random.Range(445, 675)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            NewSkeletonMinion.transform.parent = SkeletonMinionFolder.transform;
        }

        //SkeletonBossSpawner
        if (SkeletonBossFolder.transform.childCount < 10)
        {
            Randomizer = Random.Range(1, 4);
            if (Randomizer == 1)
            {
                NewSkeletonBoss = Instantiate(SkeletonBoss, new Vector3(Random.Range(230, 276), 54, Random.Range(530, 570)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer == 2)
            {
                NewSkeletonBoss = Instantiate(SkeletonBoss, new Vector3(Random.Range(279, 315), 54, Random.Range(680, 706)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer > 2)
            {
                NewSkeletonBoss = Instantiate(SkeletonBoss, new Vector3(Random.Range(120, 173), 54, Random.Range(451, 497)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            NewSkeletonBoss.transform.parent = SkeletonBossFolder.transform;
        }

        //WizzarMinionSpawner
        if (WizzardMinionFolder.transform.childCount < 30)
        {
            Randomizer = Random.Range(1, 5);
            if (Randomizer > 1)
            {
                NewWizzardMinion = Instantiate(WizzardMinion, new Vector3(Random.Range(631, 848), 91, Random.Range(644, 883)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer == 1)
            {
                NewWizzardMinion = Instantiate(WizzardMinion, new Vector3(Random.Range(700, 876), 57, Random.Range(552, 644)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            NewWizzardMinion.transform.parent = WizzardMinionFolder.transform;
        }

        //WizzardBossSpawner
        if (WizzardBossFolder.transform.childCount < 10)
        {
            Randomizer = Random.Range(1, 5);
            if (Randomizer > 2)
            {
                NewWizzardBoss = Instantiate(WizzardBoss, new Vector3(Random.Range(650, 700), 53, Random.Range(763, 838)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer == 2)
            {
                NewWizzardBoss = Instantiate(WizzardBoss, new Vector3(Random.Range(773, 792), 85, Random.Range(796, 829)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            else if (Randomizer == 1)
            {
                NewWizzardBoss = Instantiate(WizzardBoss, new Vector3(Random.Range(779, 806), 85, Random.Range(869, 895)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            }
            NewWizzardBoss.transform.parent = WizzardBossFolder.transform;
        }

        // MasterSpawnManager
        //SpiderMaster
        if (SpiderMasterSpawnPlace1.transform.childCount < 1)
        {
            if (!SpiderMaster1InSpawn)
            {
                Invoke("SpiderMaster1Spawner", 300);
                SpiderMaster1InSpawn = true;
            }
        }
        if (SpiderMasterSpawnPlace2.transform.childCount < 1)
        {
            if (!SpiderMaster2InSpawn)
            {
                Invoke("SpiderMaster2Spawner", 300);
                SpiderMaster2InSpawn = true;
            }
        }
        if (SpiderMasterSpawnPlace3.transform.childCount < 1)
        {
            if (!SpiderMaster3InSpawn)
            {
                Invoke("SpiderMaster3Spawner", 300);
                SpiderMaster3InSpawn = true;
            }
        }

        //GoblinMaster
        if (GoblinMasterSpawnPlace1.transform.childCount < 1)
        {
            if (!GoblinMaster1InSpawn)
            {
                Invoke("GoblinMaster1Spawner", 300);
                GoblinMaster1InSpawn = true;
            }
        }
        if (GoblinMasterSpawnPlace2.transform.childCount < 1)
        {
            if (!GoblinMaster2InSpawn)
            {
                Invoke("GoblinMaster2Spawner", 300);
                GoblinMaster2InSpawn = true;
            }
        }
        if (GoblinMasterSpawnPlace3.transform.childCount < 1)
        {
            if (!GoblinMaster3InSpawn)
            {
                Invoke("GoblinMaster3Spawner", 300);
                GoblinMaster3InSpawn = true;
            }
        }

        //SkeletonMaster
        if (SkeletonMasterSpawnPlace1.transform.childCount < 1)
        {
            if (!SkeletonMaster1InSpawn)
            {
                Invoke("SkeletonMaster1Spawner", 300);
                SkeletonMaster1InSpawn = true;
            }
        }
        if (SkeletonMasterSpawnPlace2.transform.childCount < 1)
        {
            if (!SkeletonMaster2InSpawn)
            {
                Invoke("SkeletonMaster2Spawner", 300);
                SkeletonMaster2InSpawn = true;
            }
        }
        if (SkeletonMasterSpawnPlace3.transform.childCount < 1)
        {
            if (!SkeletonMaster3InSpawn)
            {
                Invoke("SkeletonMaster3Spawner", 300);
                SkeletonMaster3InSpawn = true;
            }
        }

        //WizzardMasster
        if (WizzardMasterSpawnPlace1.transform.childCount < 1)
        {
            if (!WizzardMaster1InSpawn)
            {
                Invoke("WizzardMaster1Spawner", 300);
                WizzardMaster1InSpawn = true;
            }
        }
        if (WizzardMasterSpawnPlace2.transform.childCount < 1)
        {
            if (!WizzardMaster2InSpawn)
            {
                Invoke("WizzardMaster2Spawner", 300);
                WizzardMaster2InSpawn = true;
            }
        }
        if (GateKeeperSpawnPlace1.transform.childCount < 1)
        {
            if (!GateKeeper1InSpawn)
            {
                Invoke("GateKeeper1Spawner", 300);
                GateKeeper1InSpawn = true;
            }
        }
        if (GateKeeperSpawnPlace2.transform.childCount < 1)
        {
            if (!GateKeeper2InSpawn)
            {
                Invoke("GateKeeper2Spawner", 300);
                GateKeeper2InSpawn = true;
            }
        }
    }

    //MasterSpawnfunktionen
    public void SpiderMaster1Spawner()
    {
        NewSpiderMaster = Instantiate(SpiderMaster, SpiderMasterSpawnPlace1.transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        NewSpiderMaster.transform.parent = SpiderMasterSpawnPlace1.transform;
        NewSpiderMaster.GetComponent<EnemieNameScript>().Name = "Arachnoton";
        SpiderMaster1InSpawn = false;
    }
    public void SpiderMaster2Spawner()
    {
        NewSpiderMaster = Instantiate(SpiderMaster, SpiderMasterSpawnPlace2.transform.position, Quaternion.Euler(new Vector3(0, 180, 0)));
        NewSpiderMaster.transform.parent = SpiderMasterSpawnPlace2.transform;
        NewSpiderMaster.GetComponent<EnemieNameScript>().Name = "Aragok";
        SpiderMaster2InSpawn = false;
    }
    public void SpiderMaster3Spawner()
    {
        NewSpiderMaster = Instantiate(SpiderMaster, SpiderMasterSpawnPlace3.transform.position, Quaternion.Euler(new Vector3(0, 270, 0)));
        NewSpiderMaster.transform.parent = SpiderMasterSpawnPlace3.transform;
        NewSpiderMaster.GetComponent<EnemieNameScript>().Name = "Achdrias";
        SpiderMaster3InSpawn = false;
    }
    public void GoblinMaster1Spawner()
    {
        NewGoblinMaster = Instantiate(GoblinMaster, GoblinMasterSpawnPlace1.transform.position, Quaternion.Euler(new Vector3(0, 180, 0)));
        NewGoblinMaster.transform.parent = GoblinMasterSpawnPlace1.transform;
        NewGoblinMaster.GetComponent<EnemieNameScript>().Name = "Golum";
        GoblinMaster1InSpawn = false;
    }
    public void GoblinMaster2Spawner()
    {
        NewGoblinMaster = Instantiate(GoblinMaster, GoblinMasterSpawnPlace2.transform.position, Quaternion.Euler(new Vector3(0, 180, 0)));
        NewGoblinMaster.transform.parent = GoblinMasterSpawnPlace2.transform;
        NewGoblinMaster.GetComponent<EnemieNameScript>().Name = "Rakanishu";
        GoblinMaster2InSpawn = false;
    }
    public void GoblinMaster3Spawner()
    {
        NewGoblinMaster = Instantiate(GoblinMaster, GoblinMasterSpawnPlace3.transform.position, Quaternion.Euler(new Vector3(0, 300, 0)));
        NewGoblinMaster.transform.parent = GoblinMasterSpawnPlace3.transform;
        NewGoblinMaster.GetComponent<EnemieNameScript>().Name = "Gnario";
        GoblinMaster3InSpawn = false;
    }
    public void SkeletonMaster1Spawner()
    {
        NewSkeletonMaster = Instantiate(SkeletonMaster, SkeletonMasterSpawnPlace1.transform.position, Quaternion.Euler(new Vector3(0, 180, 0)));
        NewSkeletonMaster.transform.parent = SkeletonMasterSpawnPlace1.transform;
        NewSkeletonMaster.GetComponent<EnemieNameScript>().Name = "Spooky Wächter der Seelen";
        SkeletonMaster1InSpawn = false;
    }
    public void SkeletonMaster2Spawner()
    {
        NewSkeletonMaster = Instantiate(SkeletonMaster, SkeletonMasterSpawnPlace2.transform.position, Quaternion.Euler(new Vector3(0, 90, 0)));
        NewSkeletonMaster.transform.parent = SkeletonMasterSpawnPlace2.transform;
        NewSkeletonMaster.GetComponent<EnemieNameScript>().Name = "Ganondorf";
        SkeletonMaster2InSpawn = false;
    }
    public void SkeletonMaster3Spawner()
    {
        NewSkeletonMaster = Instantiate(SkeletonMaster, SkeletonMasterSpawnPlace3.transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        NewSkeletonMaster.transform.parent = SkeletonMasterSpawnPlace3.transform;
        NewSkeletonMaster.GetComponent<EnemieNameScript>().Name = "Knochentrocken";
        SkeletonMaster3InSpawn = false;

    }
    public void WizzardMaster1Spawner()
    {
        NewWizzardMaster = Instantiate(WizzardMaster, WizzardMasterSpawnPlace1.transform.position, Quaternion.Euler(new Vector3(0, 270, 0)));
        NewWizzardMaster.transform.parent = WizzardMasterSpawnPlace1.transform;
        NewWizzardMaster.GetComponent<EnemieNameScript>().Name = "Voldemort";
        WizzardMaster1InSpawn = false;
    }
    public void WizzardMaster2Spawner()
    {
        NewWizzardMaster = Instantiate(WizzardMaster, WizzardMasterSpawnPlace2.transform.position, Quaternion.Euler(new Vector3(0, 180, 0)));
        NewWizzardMaster.transform.parent = WizzardMasterSpawnPlace2.transform;
        NewWizzardMaster.GetComponent<EnemieNameScript>().Name = "Sephiroth";
        WizzardMaster2InSpawn = false;
    }
    public void GateKeeper1Spawner()
    {
        NewWizzardMaster = Instantiate(WizzardMaster, GateKeeperSpawnPlace1.transform.position, Quaternion.Euler(new Vector3(0, 180, 0)));
        NewWizzardMaster.transform.parent = GateKeeperSpawnPlace1.transform;
        NewWizzardMaster.GetComponent<EnemieNameScript>().Name = "Tiamat";
        GateKeeper1InSpawn = false;
    }
    public void GateKeeper2Spawner()
    {
        NewWizzardMaster = Instantiate(WizzardMaster, GateKeeperSpawnPlace2.transform.position, Quaternion.Euler(new Vector3(0, 180, 0)));
        NewWizzardMaster.transform.parent = GateKeeperSpawnPlace2.transform;
        NewWizzardMaster.GetComponent<EnemieNameScript>().Name = "Theostra";
        GateKeeper2InSpawn = false;
    }

}

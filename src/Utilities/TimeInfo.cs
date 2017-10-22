﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Nuterra;

namespace Utilities
{
    class TimeInfo : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Keypad3)) visible = !visible;
        }

        private void OnGUI()
        {
            if (!visible) return;
            GUI.skin.label.margin.top = 5;
            GUI.skin.label.margin.bottom = 5;
            try
            {
                GUI.Window(ID, new Rect(600f, 0, 300f, 300f), new GUI.WindowFunction(DoWindow), "Time Infos");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void DoWindow(int id)
        {
            var inst = Singleton.Manager<ManTimeOfDay>.inst;

            GUILayout.Label("Game Date" + inst.m_Sky.Cycle.DateTime);
            GUILayout.Label("Game Day : " + inst.GameDay);
            GUILayout.Label("Time of Day : " + inst.TimeOfDay);
            GUILayout.Label("Day lenght in minutes : " + inst.m_Sky.Components.Time.DayLengthInMinutes);
            GUILayout.Label("Sunrise Time : " + inst.m_Sky.SunriseTime);
            GUILayout.Label("Sunset Time : " + inst.m_Sky.SunsetTime);
            GUI.DragWindow();
        }

        public static bool visible = false;

        private int ID = Utils.GetWindowID();
    }
}

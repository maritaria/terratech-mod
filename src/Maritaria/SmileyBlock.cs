using System;
using System.IO;
using UnityEngine;

namespace Maritaria
{
	public sealed class SmileyBlock : CustomBlock
	{
		public static readonly string SpriteFile = Path.Combine(Mod.DataDirectory, "face_block.png");
		public static readonly string MyFirstBlockFile = Path.Combine(Mod.DataDirectory, "face_block.obj");
		public static readonly string MyFirstBlockData = "# Alias OBJ Model File\n# Exported from SketchUp, (c) 2000-2012 Trimble Navigation Limited\n# File units = meters\n\nmtllib face_block.mtl\n\ng Mesh1 Model\n\nusemtl FrontColor\nv 0.5 0.5 -0.5\nvt -19.685 19.685\nvn 0 0 -1\nv 0.5 -0.5 -0.5\nvt -19.685 -19.685\nv -0.5 -0.5 -0.5\nvt 19.685 -19.685\nv -0.5 0.5 -0.5\nvt 19.685 19.685\nf 1/1/1 2/2/1 3/3/1 4/4/1 \n\nusemtl Color_M01\nvn -0 -0 1\nf 4/4/2 3/3/2 2/2/2 1/1/2 \n\nusemtl FrontColor\nvn -1 -2.70717e-15 0\nv -0.5 -0.5 0.5\nv -0.5 0.5 0.5\nf 4/2/3 3/3/3 5/4/3 6/1/3 \n\nusemtl Color_M01\nvn 1 2.70717e-15 -0\nf 6/1/4 5/4/4 3/3/4 4/2/4 \n\nusemtl FrontColor\nv 0.5 -0.5 0.5\nvn 0 0 1\nv 0.5 0.5 0.5\nf 7/3/5 8/4/5 6/1/5 5/2/5 \n\nusemtl Color_M01\nvn -0 -0 -1\nf 5/2/6 6/1/6 8/4/6 7/3/6 \n\nusemtl FrontColor\nvn 1.98526e-15 1 0\nv 0.3 0.5 0.3\nvt -11.811 11.811\nf 8/1/7 9/5/7 6/4/7\n\nv 0.3 0.5 -0.3\nvt -11.811 -11.811\nf 8/1/7 10/6/7 9/5/7\n\nf 1/2/7 10/6/7 8/1/7\n\nv -0.3 0.5 -0.3\nvt 11.811 -11.811\nf 10/6/7 1/2/7 11/7/7\n\nusemtl Color_M01\nvn -1.98526e-15 -1 -0\nf 8/1/8 10/6/8 1/2/8\n\nf 9/5/8 10/6/8 8/1/8\n\nusemtl FrontColor\nv 0.3 0.3 -0.3\nvn -1 -4.06075e-15 0\nv 0.3 0.3 0\nvt -11.811 0\nv 0.3 0.3 0.3\nvt -19.685 11.811\nvt -19.685 -11.811\nf 12/6/9 13/8/9 14/5/9 9/9/9 10/10/9 \n\nv 0.229755 0.3 -0.132785\nvt 9.04547 -5.22774\nvn 4.02208e-15 -1 1.13443e-15\nvt 11.811 1.33988e-14\nf 15/11/10 12/7/10 13/12/10\n\nv 0.202897 0.3 -0.16823\nvt 7.98805 -6.62323\nf 16/13/10 12/7/10 15/11/10\n\nv 0.186829 0.3 -0.182942\nvt 7.35549 -7.20245\nf 17/14/10 12/7/10 16/13/10\n\nv 0.125468 0.3 -0.222778\nvt 4.93968 -8.7708\nf 18/15/10 12/7/10 17/14/10\n\nv 0.10648 0.3 -0.232645\nvt 4.19212 -9.15927\nf 19/16/10 12/7/10 18/15/10\n\nv 0.0810024 0.3 -0.241512\nvt 3.18907 -9.50834\nf 20/17/10 12/7/10 19/16/10\n\nv -0.3 0.3 -0.3\nf 12/7/10 20/17/10 21/6/10\n\nusemtl Color_M01\nvn -4.02208e-15 1 -1.13443e-15\nf 21/6/11 20/17/11 12/7/11\n\nusemtl FrontColor\nv -0.0957263 0.3 -0.256737\nvt -3.76875 -10.1078\nf 21/6/10 20/17/10 22/18/10\n\nusemtl Color_M01\nf 22/18/11 20/17/11 21/6/11\n\nusemtl FrontColor\nv -0.00668846 0.3 -0.249067\nvt -0.263325 -9.80577\nf 22/18/10 20/17/10 23/19/10\n\nusemtl Color_M01\nf 23/19/11 20/17/11 22/18/11\n\nusemtl FrontColor\nvt 11.811 2.36118\nvn 0.208873 1.51998e-16 -0.977943\nvt 11.811 -1.10401\nvn 0.0858325 -2.41321e-16 -0.99631\nv -0.00668846 0.5 -0.249067\nvt 19.685 -1.10401\nv 0.0810024 0.5 -0.241512\nvt 19.685 2.36118\nf 20/20/12 23/21/13 24/22/13 25/23/12 \n\nusemtl Color_M01\nvn -0.208873 -1.51998e-16 0.977943\nvn -0.0858325 2.41321e-16 0.99631\nf 25/23/14 24/22/15 23/21/15 20/20/14 \n\nusemtl FrontColor\nv -0.229707 0.5 -0.0383101\nvt 9.04357 -1.50827\nvn 1.73188e-15 1 -1.10046e-15\nv 0.23461 0.5 -0.0514291\nvt -9.23662 -2.02477\nv 0.238992 0.5 -0.0918075\nvt -9.40913 -3.61447\nv 0.238095 0.5 -0.11215\nvt -9.37383 -4.41537\nv 0.229755 0.5 -0.132785\nvt -9.04547 -5.22774\nv 0.202897 0.5 -0.16823\nvt -7.98805 -6.62323\nv 0.186829 0.5 -0.182942\nvt -7.35549 -7.20245\nv 0.163139 0.5 -0.198003\nvt -6.42279 -7.79541\nv 0.125468 0.5 -0.222778\nvt -4.93968 -8.7708\nv 0.10648 0.5 -0.232645\nvt -4.19212 -9.15927\nvt -3.18907 -9.50834\nvt 0.263325 -9.80577\nv -0.0957263 0.5 -0.256737\nvt 3.76875 -10.1078\nv -0.116856 0.5 -0.252303\nvt 4.60064 -9.9332\nv -0.136693 0.5 -0.241152\nvt 5.38161 -9.49418\nv -0.155238 0.5 -0.229927\nvt 6.11174 -9.05224\nv -0.175099 0.5 -0.210755\nvt 6.89367 -8.29745\nv -0.200196 0.5 -0.174495\nvt 7.88171 -6.86988\nv -0.217174 0.5 -0.127402\nvt 8.55015 -5.01584\nv -0.224811 0.5 -0.085437\nvt 8.85083 -3.36366\nf 26/24/16 27/25/16 28/26/16 29/27/16 30/28/16 31/29/16 32/30/16 33/31/16 34/32/16 35/33/16 25/34/16 24/35/16 36/36/16 37/37/16 38/38/16 39/39/16 40/40/16 41/41/16 42/42/16 43/43/16 \n\nusemtl Color_M01\nvn -1.73188e-15 -1 1.10046e-15\nf 43/43/17 42/42/17 41/41/17 40/40/17 39/39/17 38/38/17 37/37/17 36/36/17 24/35/17 25/34/17 35/33/17 34/32/17 33/31/17 32/30/17 31/29/17 30/28/17 29/27/17 28/26/17 27/25/17 26/24/17 \n\nusemtl FrontColor\nv -0.217174 0.3 -0.127402\nvt -11.811 -3.40394\nvn -0.965609 -1.9208e-15 -0.259999\nv -0.224811 0.3 -0.085437\nvt -11.811 -1.72462\nvn -0.989968 -5.59289e-16 -0.141288\nvt -19.685 -1.72462\nvt -19.685 -3.40394\nf 44/44/18 45/45/19 43/46/19 42/47/18 \n\nv -0.3 0.3 0.3\nvt -8.55015 -5.01584\nvt -8.85083 -3.36366\nf 46/5/10 44/48/10 45/49/10\n\nf 21/6/10 44/48/10 46/5/10\n\nv -0.200196 0.3 -0.174495\nvt -7.88171 -6.86988\nf 44/48/10 21/6/10 47/50/10\n\nusemtl Color_M01\nf 46/5/11 44/48/11 21/6/11\n\nf 45/49/11 44/48/11 46/5/11\n\nvn 0.965609 1.9208e-15 0.259999\nvn 0.989968 5.59289e-16 0.141288\nf 42/47/20 43/46/21 45/45/21 44/44/20 \n\nusemtl FrontColor\nvt -11.811 -2.43113\nv -0.229707 0.3 -0.0383101\nvt -11.811 -0.565761\nvn -0.994648 -8.97671e-16 -0.103326\nvt -19.685 -0.565761\nvt -19.685 -2.43113\nf 45/51/19 48/52/22 26/53/22 43/54/19 \n\nvt -9.04357 -1.50827\nf 46/5/10 45/49/10 48/55/10\n\nusemtl Color_M01\nf 48/55/11 45/49/11 46/5/11\n\nvn 0.994648 8.97671e-16 0.103326\nf 43/54/21 26/53/23 48/52/23 45/51/21 \n\nusemtl FrontColor\nvt 11.811 8.99736\nvn 0.028243 2.05513e-17 0.999601\nv 0.23461 0.3 -0.0514291\nvt 11.811 -9.29012\nvt 19.685 -9.29012\nvt 19.685 8.99736\nf 48/56/24 49/57/24 27/58/24 26/59/24 \n\nvt 9.23662 -2.02477\nf 49/60/10 13/12/10 48/55/10\n\nv 0.238992 0.3 -0.0918075\nvt 9.40913 -3.61447\nf 50/61/10 13/12/10 49/60/10\n\nv 0.238095 0.3 -0.11215\nvt 9.37383 -4.41537\nf 51/62/10 13/12/10 50/61/10\n\nf 15/11/10 13/12/10 51/62/10\n\nusemtl Color_M01\nf 13/12/11 12/7/11 15/11/11\n\nvn 1 4.06075e-15 -0\nf 10/10/25 9/9/25 14/5/25 13/8/25 12/6/25 \n\nusemtl FrontColor\nvt 11.811 11.811\nvt 11.811 19.685\nv -0.3 0.5 0.3\nvt -11.811 19.685\nv -3.2486e-15 0.3 0.3\nvt -1.27898e-13 11.811\nf 14/63/5 9/64/5 52/65/5 46/5/5 53/66/5 \n\nusemtl Color_M01\nf 53/66/6 46/5/6 52/65/6 9/64/6 14/63/6 \n\nusemtl FrontColor\nvt -8.03928e-14 11.811\nf 46/5/10 14/63/10 53/67/10\n\nv -0.199795 0.3 0.216078\nvt -7.86595 8.50702\nf 46/5/10 54/68/10 14/63/10\n\nv -0.208974 0.3 0.213514\nvt -8.22731 8.40608\nf 46/5/10 55/69/10 54/68/10\n\nv -0.219457 0.3 0.213487\nvt -8.64005 8.40498\nf 46/5/10 56/70/10 55/69/10\n\nv -0.228694 0.3 0.208368\nvt -9.0037 8.20348\nf 46/5/10 57/71/10 56/70/10\n\nv -0.232724 0.3 0.199432\nvt -9.16236 7.85167\nf 46/5/10 58/72/10 57/71/10\n\nv -0.231458 0.3 0.194334\nvt -9.11252 7.65096\nf 46/5/10 59/73/10 58/72/10\n\nv -0.227657 0.3 0.179029\nvt -8.96287 7.0484\nf 46/5/10 60/74/10 59/73/10\n\nf 46/5/10 48/55/10 60/74/10\n\nusemtl Color_M01\nf 60/74/11 48/55/11 46/5/11\n\nusemtl FrontColor\nv -0.217252 0.3 0.16631\nvt -8.55321 6.54762\nf 60/74/10 48/55/10 61/75/10\n\nusemtl Color_M01\nf 61/75/11 48/55/11 60/74/11\n\nusemtl FrontColor\nv -0.187282 0.3 0.139681\nvt -7.3733 5.49924\nf 61/75/10 48/55/10 62/76/10\n\nusemtl Color_M01\nf 62/76/11 48/55/11 61/75/11\n\nusemtl FrontColor\nv -0.172952 0.3 0.129578\nvt -6.80915 5.1015\nf 62/76/10 48/55/10 63/77/10\n\nusemtl Color_M01\nf 63/77/11 48/55/11 62/76/11\n\nusemtl FrontColor\nf 63/77/10 48/55/10 13/12/10\n\nusemtl Color_M01\nf 13/12/11 48/55/11 63/77/11\n\nf 48/55/11 13/12/11 49/60/11\n\nf 49/60/11 13/12/11 50/61/11\n\nf 50/61/11 13/12/11 51/62/11\n\nf 51/62/11 13/12/11 15/11/11\n\nusemtl FrontColor\nvt 11.811 -0.580802\nvn 0.977171 2.27775e-15 -0.212452\nvt 11.811 -1.45703\nvn 0.869662 2.67044e-15 -0.493648\nvt 19.685 -1.45703\nvt 19.685 -0.580802\nf 51/78/26 15/79/27 30/80/27 29/81/26 \n\nusemtl Color_M01\nvn -0.977171 -2.27775e-15 0.212452\nvn -0.869662 -2.67044e-15 0.493648\nf 29/81/28 30/80/29 15/79/29 51/78/28 \n\nusemtl FrontColor\nvt 11.811 1.29626\nvt 11.811 -0.4546\nvn 0.739203 1.92374e-15 -0.673483\nvt 19.685 -0.4546\nvt 19.685 1.29626\nf 15/82/27 16/83/30 31/84/30 30/85/27 \n\nusemtl Color_M01\nf 15/11/11 12/7/11 16/13/11\n\nf 16/13/11 12/7/11 17/14/11\n\nf 17/14/11 12/7/11 18/15/11\n\nf 18/15/11 12/7/11 19/16/11\n\nf 19/16/11 12/7/11 20/17/11\n\nusemtl FrontColor\nvt 11.811 0.948741\nvn 0.395924 1.74394e-15 -0.918283\nvt 11.811 -0.113313\nvt 19.685 -0.113313\nvt 19.685 0.948741\nf 19/86/31 20/87/12 25/88/12 35/89/31 \n\nusemtl Color_M01\nvn -0.395924 -1.74394e-15 0.918283\nf 35/89/32 25/88/14 20/87/14 19/86/32 \n\nusemtl FrontColor\nvt 11.811 0.338917\nvn 0.505958 2.27669e-15 -0.862558\nvt 11.811 -0.503549\nvt 19.685 -0.503549\nvt 19.685 0.338917\nf 18/90/33 19/91/31 35/92/31 34/93/33 \n\nusemtl Color_M01\nvn -0.505958 -2.27669e-15 0.862558\nf 34/93/34 35/92/32 19/91/32 18/90/34 \n\nusemtl FrontColor\nv 0.163139 0.3 -0.198003\nvt 11.811 1.08286\nvn 0.543009 1.59319e-15 -0.839727\nvt 11.811 -0.692252\nvt 19.685 -0.692252\nvt 19.685 1.08286\nf 64/94/35 18/95/33 34/96/33 33/97/35 \n\nvt 6.42279 -7.79541\nf 18/15/10 17/14/10 64/98/10\n\nusemtl Color_M01\nf 64/98/11 17/14/11 18/15/11\n\nusemtl FrontColor\nvt 11.811 2.34313\nvn 0.608247 1.568e-15 -0.793748\nvt 11.811 1.23791\nvt 19.685 1.23791\nvt 19.685 2.34313\nf 17/99/36 64/100/35 33/101/35 32/102/36 \n\nusemtl Color_M01\nvn -0.608247 -1.568e-15 0.793748\nvn -0.543009 -1.59319e-15 0.839727\nf 32/102/37 33/101/38 64/100/38 17/99/37 \n\nf 33/97/38 34/96/34 18/95/34 64/94/38 \n\nusemtl FrontColor\nvt 11.811 1.41845\nvt 11.811 0.560763\nvt 19.685 0.560763\nvt 19.685 1.41845\nf 16/103/30 17/104/36 32/105/36 31/106/30 \n\nusemtl Color_M01\nvn -0.739203 -1.92374e-15 0.673483\nf 31/106/39 32/105/37 17/104/37 16/103/39 \n\nf 30/85/29 31/84/39 16/83/39 15/82/29 \n\nusemtl FrontColor\nvt 11.811 -3.19668\nvn 0.999487 1.12847e-15 0.0320179\nvt 11.811 -3.99836\nvt 19.685 -3.99836\nvt 19.685 -3.19668\nf 50/107/40 51/108/26 29/109/26 28/110/40 \n\nusemtl Color_M01\nvn -0.999487 -1.12847e-15 -0.0320179\nf 28/110/41 29/109/28 51/108/28 50/107/41 \n\nusemtl FrontColor\nvt 11.811 -3.0094\nvn 0.994164 8.98241e-16 0.10788\nvt 11.811 -4.60843\nvt 19.685 -4.60843\nvt 19.685 -3.0094\nf 49/111/42 50/112/40 28/113/40 27/114/42 \n\nusemtl Color_M01\nvn -0.994164 -8.98241e-16 -0.10788\nf 27/114/43 28/113/41 50/112/41 49/111/43 \n\nvn -0.028243 -2.05513e-17 -0.999601\nf 26/59/44 27/58/44 49/57/44 48/56/44 \n\nusemtl FrontColor\nv 0.193579 0.3 0.130612\nvt 7.62123 5.14219\nf 13/12/10 65/115/10 63/77/10\n\nv 0.218087 0.3 0.133328\nvt 8.5861 5.24913\nf 65/115/10 13/12/10 66/116/10\n\nusemtl Color_M01\nf 63/77/11 65/115/11 13/12/11\n\nusemtl FrontColor\nv -0.15728 0.3 0.129728\nvt -6.19212 5.10742\nf 63/77/10 65/115/10 67/117/10\n\nusemtl Color_M01\nf 67/117/11 65/115/11 63/77/11\n\nusemtl FrontColor\nv -0.136419 0.3 0.136303\nvt -5.37082 5.36626\nf 65/115/10 68/118/10 67/117/10\n\nv 0.181165 0.3 0.13794\nvt 7.13247 5.43069\nf 68/118/10 65/115/10 69/119/10\n\nusemtl Color_M01\nf 67/117/11 68/118/11 65/115/11\n\nusemtl FrontColor\nvt -11.811 -4.37052\nvn -0.1568 -1.02728e-15 0.98763\nvt -11.811 -3.5094\nvn -0.540303 -3.88043e-15 0.84147\nv -0.136419 0.5 0.136303\nvt -19.685 -3.5094\nv -0.15728 0.5 0.129728\nvt -19.685 -4.37052\nf 67/120/45 68/121/46 70/122/46 71/123/45 \n\nusemtl Color_M01\nvn 0.1568 1.02728e-15 -0.98763\nvn 0.540303 3.88043e-15 -0.84147\nf 71/123/47 70/122/48 68/121/48 67/120/47 \n\nusemtl FrontColor\nv -0.172952 0.5 0.129578\nvn 6.55836e-15 -1 2.59216e-15\nv -0.125991 0.5 0.14785\nvt -4.96027 5.82088\nv -0.129822 0.5 0.163072\nvt -5.1111 6.42014\nv -0.137543 0.5 0.176986\nvt -5.41507 6.96795\nv -0.168581 0.5 0.203481\nvt -6.63704 8.01108\nv -0.199795 0.5 0.216078\nv -0.208974 0.5 0.213514\nv -0.219457 0.5 0.213487\nv -0.228694 0.5 0.208368\nv -0.232724 0.5 0.199432\nv -0.231458 0.5 0.194334\nv -0.227657 0.5 0.179029\nv -0.217252 0.5 0.16631\nv -0.187282 0.5 0.139681\nf 72/77/49 71/117/49 70/118/49 73/124/49 74/125/49 75/126/49 76/127/49 77/68/49 78/69/49 79/70/49 80/71/49 81/72/49 82/73/49 83/74/49 84/75/49 85/76/49 \n\nusemtl Color_M01\nvn -6.55836e-15 1 -2.59216e-15\nf 85/76/50 84/75/50 83/74/50 82/73/50 81/72/50 80/71/50 79/70/50 78/69/50 77/68/50 76/127/50 75/126/50 74/125/50 73/124/50 70/118/50 71/117/50 72/77/50 \n\nusemtl FrontColor\nvt 11.811 10.7429\nvn 0.72138 1.76639e-15 0.69254\nvt 11.811 9.16453\nvn 0.621195 2.86337e-15 0.783656\nvt 19.685 9.16453\nvt 19.685 10.7429\nf 61/128/51 62/129/52 85/130/52 84/131/51 \n\nusemtl Color_M01\nvn -0.72138 -1.76639e-15 -0.69254\nvn -0.621195 -2.86337e-15 -0.783656\nf 84/131/53 85/130/54 62/129/54 61/128/53 \n\nusemtl FrontColor\nvt 11.811 9.19493\nvt 11.811 8.50467\nvn 0.297672 1.94411e-15 0.954668\nvt 19.685 8.50467\nvt 19.685 9.19493\nf 62/132/52 63/133/55 72/134/55 85/135/52 \n\nusemtl Color_M01\nvn -0.297672 -1.94411e-15 -0.954668\nf 85/135/54 72/134/56 63/133/56 62/132/54 \n\nusemtl FrontColor\nvt -11.811 -6.75992\nvt -11.811 -6.14286\nvt -19.685 -6.14286\nvt -19.685 -6.75992\nf 63/136/55 67/137/45 71/138/45 72/139/55 \n\nusemtl Color_M01\nf 72/139/56 71/138/47 67/137/47 63/136/56 \n\nusemtl FrontColor\nvt 11.811 11.1306\nvn 0.894029 1.92752e-15 0.448009\nvt 11.811 10.4836\nvt 19.685 10.4836\nvt 19.685 11.1306\nf 60/140/57 61/141/51 84/142/51 83/143/57 \n\nusemtl Color_M01\nvn -0.894029 -1.92752e-15 -0.448009\nf 83/143/58 84/142/53 61/141/53 60/140/58 \n\nusemtl FrontColor\nvt 11.811 9.62178\nvn 0.970518 1.9707e-15 0.24103\nvt 11.811 9.00092\nvt 19.685 9.00092\nvt 19.685 9.62178\nf 59/144/59 60/145/57 83/146/57 82/147/59 \n\nusemtl Color_M01\nf 59/73/11 60/74/11 46/5/11\n\nvn -0.970518 -1.9707e-15 -0.24103\nf 82/147/60 83/146/58 60/145/58 59/144/60 \n\nusemtl FrontColor\nvt 11.811 9.82859\nvn 0.995942 1.36191e-15 -0.0899996\nvt 19.685 9.82859\nf 58/148/61 59/144/59 82/147/59 81/149/61 \n\nusemtl Color_M01\nf 58/72/11 59/73/11 46/5/11\n\nvn -0.995942 -1.36191e-15 0.0899996\nf 81/149/62 82/147/60 59/144/60 58/148/62 \n\nusemtl FrontColor\nvt 11.811 3.77668\nvn 0.735604 6.05661e-16 -0.677411\nvt 11.811 3.39074\nvt 19.685 3.39074\nvt 19.685 3.77668\nf 57/150/63 58/151/61 81/152/61 80/153/63 \n\nusemtl Color_M01\nf 57/71/11 58/72/11 46/5/11\n\nvn -0.735604 -6.05661e-16 0.677411\nf 80/153/64 81/152/62 58/151/62 57/150/64 \n\nusemtl FrontColor\nvt 11.811 -3.48374\nvn 0.251586 1.75421e-16 -0.967835\nvt 11.811 -3.89948\nvt 19.685 -3.89948\nvt 19.685 -3.48374\nf 56/154/65 57/155/63 80/156/63 79/157/65 \n\nusemtl Color_M01\nf 56/70/11 57/71/11 46/5/11\n\nvn -0.251586 -1.75421e-16 0.967835\nf 79/157/66 80/156/64 57/155/64 56/154/66 \n\nusemtl FrontColor\nvt 11.811 -8.20503\nvn 0.137091 8.94247e-16 -0.990558\nvt 11.811 -8.61778\nvt 19.685 -8.61778\nvt 19.685 -8.20503\nf 55/158/67 56/159/65 79/160/65 78/161/67 \n\nusemtl Color_M01\nf 55/69/11 56/70/11 46/5/11\n\nvn -0.137091 -8.94247e-16 0.990558\nf 78/161/68 79/160/66 56/159/66 55/158/68 \n\nusemtl FrontColor\nvt 11.811 -5.28714\nvn -0.0555566 -4.53422e-16 -0.998456\nvt 11.811 -5.66234\nvt 19.685 -5.66234\nvt 19.685 -5.28714\nf 54/162/69 55/163/67 78/164/67 77/165/69 \n\nusemtl Color_M01\nf 54/68/11 55/69/11 46/5/11\n\nvn 0.0555566 4.53422e-16 0.998456\nf 77/165/70 78/164/68 55/163/68 54/162/70 \n\nusemtl FrontColor\nv -0.168581 0.3 0.203481\nvt -11.811 9.15278\nvn -0.518494 -3.9234e-15 -0.855081\nvt -11.811 10.478\nvt -19.685 10.478\nvt -19.685 9.15278\nf 86/166/71 54/167/69 77/168/69 76/169/71 \n\nv 0.176547 0.3 0.205916\nvt 6.95067 8.10693\nf 86/127/10 87/170/10 54/68/10\n\nv -0.137543 0.3 0.176986\nf 88/126/10 87/170/10 86/127/10\n\nv 0.165866 0.3 0.176238\nvt 6.53016 6.9385\nf 88/126/10 89/171/10 87/170/10\n\nv -0.129822 0.3 0.163072\nf 90/125/10 89/171/10 88/126/10\n\nv 0.172353 0.3 0.15151\nvt 6.78557 5.96498\nf 90/125/10 91/172/10 89/171/10\n\nv -0.125991 0.3 0.14785\nf 92/124/10 91/172/10 90/125/10\n\nf 92/124/10 69/119/10 91/172/10\n\nf 68/118/10 69/119/10 92/124/10\n\nusemtl Color_M01\nf 69/119/11 65/115/11 68/118/11\n\nusemtl FrontColor\nvt 11.811 -3.38161\nvn 0.691878 1.46544e-15 0.722015\nvt 11.811 -3.94917\nvn 0.209859 5.26322e-16 0.977732\nv 0.193579 0.5 0.130612\nvt 19.685 -3.94917\nv 0.181165 0.5 0.13794\nvt 19.685 -3.38161\nf 69/173/72 65/174/73 93/175/73 94/176/72 \n\nusemtl Color_M01\nvn -0.691878 -1.46544e-15 -0.722015\nvn -0.209859 -5.26322e-16 -0.977732\nf 94/176/74 93/175/75 65/174/75 69/173/74 \n\nusemtl FrontColor\nv 0.236053 0.5 0.15572\nvt 9.29341 6.13069\nvn 1.75554e-15 -1 3.71061e-15\nv 0.231983 0.5 0.180318\nvt 9.1332 7.09913\nv 0.225668 0.5 0.193806\nvt 8.88455 7.63017\nv 0.214534 0.5 0.203588\nvt 8.44623 8.01529\nv 0.190041 0.5 0.205962\nvt 7.48192 8.10873\nv 0.176547 0.5 0.205916\nv 0.165866 0.5 0.176238\nv 0.172353 0.5 0.15151\nv 0.218087 0.5 0.133328\nv 0.23264 0.5 0.140882\nvt 9.15907 5.54655\nf 95/177/76 96/178/76 97/179/76 98/180/76 99/181/76 100/170/76 101/171/76 102/172/76 94/119/76 93/115/76 103/116/76 104/182/76 \n\nusemtl Color_M01\nvn -1.75554e-15 1 -3.71061e-15\nf 104/182/77 103/116/77 93/115/77 94/119/77 102/172/77 101/171/77 100/170/77 99/181/77 98/180/77 97/179/77 96/178/77 95/177/77 \n\nusemtl FrontColor\nvt -11.811 10.0389\nvn -0.290353 -4.9852e-16 0.95692\nv 0.23264 0.3 0.140882\nvt -11.811 10.6845\nvn -0.790592 -2.15424e-15 0.612343\nvt -19.685 10.6845\nvt -19.685 10.0389\nf 66/183/78 105/184/79 104/185/79 103/186/78 \n\nf 66/116/10 13/12/10 105/182/10\n\nusemtl Color_M01\nf 66/116/11 13/12/11 65/115/11\n\nf 105/182/11 13/12/11 66/116/11\n\nusemtl FrontColor\nf 105/182/10 13/12/10 14/63/10\n\nusemtl Color_M01\nf 14/63/11 13/12/11 105/182/11\n\nusemtl FrontColor\nv 0.3 -0.25 0\nvt -9.84252 0\nvn 1 -8.20354e-16 0\nvt 11.811 0\nv 0.3 -0.25 0.3\nvt -9.84252 11.811\nf 106/187/80 13/188/80 14/63/80 107/189/80 \n\nusemtl Color_M01\nvn -1 8.20354e-16 -0\nf 107/189/81 14/63/81 13/188/81 106/187/81 \n\nusemtl FrontColor\nvt 11.811 -9.84252\nv -2.61693e-15 -0.25 0.3\nvt -1.03029e-13 -9.84252\nf 107/190/5 14/63/5 53/66/5 108/191/5 \n\nusemtl Color_M01\nf 108/191/6 53/66/6 14/63/6 107/190/6 \n\nf 53/67/11 14/63/11 46/5/11\n\nf 14/63/11 54/68/11 46/5/11\n\nusemtl FrontColor\nv 0.190041 0.3 0.205962\nf 109/181/10 14/63/10 54/68/10\n\nv 0.214534 0.3 0.203588\nf 110/180/10 14/63/10 109/181/10\n\nv 0.225668 0.3 0.193806\nf 111/179/10 14/63/10 110/180/10\n\nv 0.231983 0.3 0.180318\nf 112/178/10 14/63/10 111/179/10\n\nv 0.236053 0.3 0.15572\nf 113/177/10 14/63/10 112/178/10\n\nf 105/182/10 14/63/10 113/177/10\n\nusemtl Color_M01\nf 113/177/11 14/63/11 105/182/11\n\nf 112/178/11 14/63/11 113/177/11\n\nf 111/179/11 14/63/11 112/178/11\n\nf 110/180/11 14/63/11 111/179/11\n\nf 109/181/11 14/63/11 110/180/11\n\nf 54/68/11 14/63/11 109/181/11\n\nusemtl FrontColor\nf 54/68/10 87/170/10 109/181/10\n\nusemtl Color_M01\nf 54/68/11 87/170/11 86/127/11\n\nf 109/181/11 87/170/11 54/68/11\n\nusemtl FrontColor\nvt 11.811 7.50929\nvn -0.0465898 -5.25668e-17 -0.998914\nvt 11.811 6.97803\nvn 0.576434 9.0908e-16 -0.817144\nvt 19.685 6.97803\nvt 19.685 7.50929\nf 109/192/82 87/193/83 100/194/83 99/195/82 \n\nusemtl Color_M01\nvn 0.0465898 5.25668e-17 0.998914\nvn -0.576434 -9.0908e-16 0.817144\nf 99/195/84 100/194/85 87/193/85 109/192/84 \n\nusemtl FrontColor\nvt 11.811 9.98168\nvt 11.811 8.73988\nvn 0.999012 1.80624e-15 -0.0444303\nvt 19.685 8.73988\nvt 19.685 9.98168\nf 87/196/83 89/197/86 101/198/86 100/199/83 \n\nusemtl Color_M01\nf 87/170/11 89/171/11 88/126/11\n\nvn -0.999012 -1.80624e-15 0.0444303\nf 100/199/85 101/198/87 89/197/87 87/196/85 \n\nusemtl FrontColor\nvt 11.811 5.05425\nvt 11.811 4.04778\nvn 0.914624 1.85854e-15 0.404306\nvt 19.685 4.04778\nvt 19.685 5.05425\nf 89/200/86 91/201/88 102/202/88 101/203/86 \n\nusemtl Color_M01\nf 89/171/11 91/172/11 90/125/11\n\nvn -0.914624 -1.85854e-15 -0.404306\nf 101/203/87 102/202/89 91/201/89 89/200/87 \n\nusemtl FrontColor\nvt 11.811 1.30776\nvt 11.811 0.670738\nvt 19.685 0.670738\nvt 19.685 1.30776\nf 91/204/88 69/205/72 94/206/72 102/207/88 \n\nusemtl Color_M01\nf 91/172/11 69/119/11 92/124/11\n\nf 102/207/89 94/206/74 69/205/74 91/204/89 \n\nf 92/124/11 69/119/11 68/118/11\n\nusemtl FrontColor\nvt -11.811 0.382956\nvt -11.811 0.995519\nvn -0.970387 -7.09962e-15 0.241556\nvt -19.685 0.995519\nvt -19.685 0.382956\nf 68/208/46 92/209/90 73/210/90 70/211/46 \n\nusemtl Color_M01\nvn 0.970387 7.09962e-15 -0.241556\nf 70/211/48 73/210/91 92/209/91 68/208/48 \n\nusemtl FrontColor\nvt -11.811 6.85554\nvt -11.811 7.47349\nvn -0.929927 -6.71399e-15 -0.367744\nvt -19.685 7.47349\nvt -19.685 6.85554\nf 92/212/90 90/213/92 74/214/92 73/215/90 \n\nusemtl Color_M01\nf 90/125/11 91/172/11 92/124/11\n\nvn 0.929927 6.71399e-15 0.367744\nf 73/215/91 74/214/93 90/213/93 92/212/91 \n\nusemtl FrontColor\nvt -11.811 8.09369\nvt -11.811 8.72019\nvn -0.774173 -5.81245e-15 -0.632974\nvt -19.685 8.72019\nvt -19.685 8.09369\nf 90/216/92 88/217/94 75/218/94 74/219/92 \n\nusemtl Color_M01\nf 88/126/11 89/171/11 90/125/11\n\nvn 0.774173 5.81245e-15 0.632974\nf 74/219/93 75/218/95 88/217/95 90/216/93 \n\nusemtl FrontColor\nvt -11.811 8.64252\nvt -11.811 10.2492\nvt -19.685 10.2492\nvt -19.685 8.64252\nf 88/220/94 86/221/71 76/222/71 75/223/94 \n\nusemtl Color_M01\nf 86/127/11 87/170/11 88/126/11\n\nvn 0.518494 3.9234e-15 0.855081\nf 75/223/95 76/222/96 86/221/96 88/220/95 \n\nf 76/169/96 77/168/70 54/167/70 86/166/96 \n\nusemtl FrontColor\nvt -11.811 -7.63384\nvn -0.397452 3.33907e-16 -0.917623\nvt -11.811 -6.66501\nvt -19.685 -6.66501\nvt -19.685 -7.63384\nf 110/224/97 109/225/82 99/226/82 98/227/97 \n\nusemtl Color_M01\nvn 0.397452 -3.33907e-16 0.917623\nf 98/227/98 99/226/84 109/225/84 110/224/98 \n\nusemtl FrontColor\nvt -11.811 -1.638\nvn -0.799751 9.02442e-16 -0.600331\nvt -11.811 -1.05453\nvt -19.685 -1.05453\nvt -19.685 -1.638\nf 111/228/99 110/229/97 98/230/97 97/231/99 \n\nusemtl Color_M01\nvn 0.799751 -9.02442e-16 0.600331\nf 97/231/100 98/230/98 110/229/98 111/228/100 \n\nusemtl FrontColor\nvt -11.811 2.55627\nvn -0.955061 -4.94935e-16 -0.29641\nvt -11.811 3.14264\nvt -19.685 3.14264\nvt -19.685 2.55627\nf 112/232/101 111/233/99 97/234/99 96/235/101 \n\nusemtl Color_M01\nvn 0.955061 4.94935e-16 0.29641\nf 96/235/102 97/234/100 111/233/100 112/232/102 \n\nusemtl FrontColor\nvt -11.811 4.53168\nvn -0.999518 -2.59062e-15 0.0310466\nvt -11.811 5.51328\nvt -19.685 5.51328\nvt -19.685 4.53168\nf 113/236/103 112/237/101 96/238/101 95/239/103 \n\nusemtl Color_M01\nvn 0.999518 2.59062e-15 -0.0310466\nf 95/239/104 96/238/102 112/237/102 113/236/104 \n\nusemtl FrontColor\nvt -11.811 7.45826\nvt -11.811 8.05765\nvt -19.685 8.05765\nvt -19.685 7.45826\nf 105/240/79 113/241/103 95/242/103 104/243/79 \n\nusemtl Color_M01\nvn 0.790592 2.15424e-15 -0.612343\nf 104/243/105 95/242/104 113/241/104 105/240/105 \n\nvn 0.290353 4.9852e-16 -0.95692\nf 103/186/106 104/185/105 105/184/105 66/183/106 \n\nusemtl FrontColor\nvt -11.811 8.14132\nvt -11.811 9.1121\nvt -19.685 9.1121\nvt -19.685 8.14132\nf 65/244/73 66/245/78 103/246/78 93/247/73 \n\nusemtl Color_M01\nf 93/247/75 103/246/106 66/245/106 65/244/75 \n\nusemtl FrontColor\nvn -2.85757e-15 -1 0\nvt -7.4903e-14 11.811\nv -2.61693e-15 -0.25 0\nvt -7.4903e-14 0\nf 107/63/107 108/248/107 114/249/107 106/188/107 \n\nusemtl Color_M01\nvn 2.85757e-15 1 -0\nf 106/188/108 114/249/108 108/248/108 107/63/108 \n\nusemtl FrontColor\nvn 1 5.41434e-15 0\nvt 19.685 -11.811\nvt 19.685 11.811\nf 21/7/109 11/250/109 52/251/109 46/63/109 \n\nusemtl Color_M01\nvn -1 -5.41434e-15 -0\nf 46/63/110 52/251/110 11/250/110 21/7/110 \n\nusemtl FrontColor\nf 11/7/7 6/4/7 52/63/7\n\nf 11/7/7 4/3/7 6/4/7\n\nf 4/3/7 11/7/7 1/2/7\n\nusemtl Color_M01\nf 1/2/8 11/7/8 4/3/8\n\nf 11/7/8 1/2/8 10/6/8\n\nusemtl FrontColor\nf 12/63/5 10/64/5 11/65/5 21/5/5 \n\nusemtl Color_M01\nf 21/5/6 11/65/6 10/64/6 12/63/6 \n\nf 6/4/8 4/3/8 11/7/8\n\nf 52/63/8 6/4/8 11/7/8\n\nusemtl FrontColor\nf 52/63/7 6/4/7 9/5/7\n\nusemtl Color_M01\nf 9/5/8 6/4/8 52/63/8\n\nf 6/4/8 9/5/8 8/1/8\n\nusemtl FrontColor\nvt -11.811 -3.7895\nvn -0.888963 -4.71989e-15 -0.45798\nvt -11.811 -1.81865\nvt -19.685 -1.81865\nvt -19.685 -3.7895\nf 47/252/111 44/253/18 42/254/18 41/255/111 \n\nusemtl Color_M01\nf 47/50/11 21/6/11 44/48/11\n\nusemtl FrontColor\nv -0.175099 0.3 -0.210755\nvt -6.89367 -8.29745\nf 47/50/10 21/6/10 115/256/10\n\nusemtl Color_M01\nf 115/256/11 21/6/11 47/50/11\n\nusemtl FrontColor\nv -0.155238 0.3 -0.229927\nvt -6.11174 -9.05224\nf 115/256/10 21/6/10 116/257/10\n\nusemtl Color_M01\nf 116/257/11 21/6/11 115/256/11\n\nusemtl FrontColor\nv -0.136693 0.3 -0.241152\nvt -5.38161 -9.49418\nf 116/257/10 21/6/10 117/258/10\n\nusemtl Color_M01\nf 117/258/11 21/6/11 116/257/11\n\nusemtl FrontColor\nv -0.116856 0.3 -0.252303\nvt -4.60064 -9.9332\nf 117/258/10 21/6/10 118/259/10\n\nusemtl Color_M01\nf 118/259/11 21/6/11 117/258/11\n\nusemtl FrontColor\nf 118/259/10 21/6/10 22/18/10\n\nusemtl Color_M01\nf 22/18/11 21/6/11 118/259/11\n\nusemtl FrontColor\nvt -11.811 1.61257\nvn -0.0604156 -6.43796e-16 -0.998173\nvt -11.811 2.46258\nvn -0.351787 -2.8228e-15 -0.93608\nvt -19.685 2.46258\nvt -19.685 1.61257\nf 22/260/112 118/261/113 37/262/113 36/263/112 \n\nusemtl Color_M01\nvn 0.0604156 6.43796e-16 0.998173\nvn 0.351787 2.8228e-15 0.93608\nf 36/263/114 37/262/115 118/261/115 22/260/114 \n\nusemtl FrontColor\nvt -11.811 -0.857076\nvt -11.811 0.0388253\nvn -0.503987 -4.78163e-15 -0.863711\nvt -19.685 0.0388253\nvt -19.685 -0.857076\nf 118/264/113 117/265/116 38/266/116 37/267/113 \n\nusemtl Color_M01\nvn 0.503987 4.78163e-15 0.863711\nf 37/267/115 38/266/117 117/265/117 118/264/115 \n\nusemtl FrontColor\nvt -11.811 -0.31237\nvt -11.811 0.541093\nvn -0.609969 -5.34451e-15 -0.792426\nvt -19.685 0.541093\nvt -19.685 -0.31237\nf 117/268/116 116/269/118 39/270/118 38/271/116 \n\nusemtl Color_M01\nvn 0.609969 5.34451e-15 0.792426\nf 38/271/117 39/270/119 116/269/119 117/268/117 \n\nusemtl FrontColor\nvt -11.811 -1.88961\nvt -11.811 -0.802807\nvn -0.762107 -5.64466e-15 -0.647451\nvt -19.685 -0.802807\nvt -19.685 -1.88961\nf 116/272/118 115/273/120 40/274/120 39/275/118 \n\nusemtl Color_M01\nvn 0.762107 5.64466e-15 0.647451\nf 39/275/119 40/274/121 115/273/121 116/272/119 \n\nusemtl FrontColor\nvt -11.811 -2.89949\nvt -11.811 -1.16335\nvt -19.685 -1.16335\nvt -19.685 -2.89949\nf 115/276/120 47/277/111 41/278/111 40/279/120 \n\nusemtl Color_M01\nvn 0.888963 4.71989e-15 0.45798\nf 40/279/121 41/278/122 47/277/122 115/276/121 \n\nf 41/255/122 42/254/20 44/253/20 47/252/122 \n\nusemtl FrontColor\nvt 11.811 -4.62242\nvt 19.685 -4.62242\nf 23/21/13 22/280/112 36/281/112 24/22/13 \n\nusemtl Color_M01\nf 24/22/15 36/281/114 22/280/114 23/21/15 \n\nusemtl FrontColor\nvn 1 -9.02389e-16 0\nf 2/2/123 1/3/123 8/4/123 7/1/123 \n\nusemtl Color_M01\nvn -1 9.02389e-16 -0\nf 7/1/124 8/4/124 1/3/124 2/2/124 \n\nusemtl FrontColor\nvn -5.41434e-16 -1 0\nf 3/2/125 2/3/125 7/4/125 5/1/125 \n\nusemtl Color_M01\nvn 5.41434e-16 1 -0\nf 5/1/126 7/4/126 2/3/126 3/2/126 \n\n";
		
		public static readonly int BlockID = 9000;
		
		int CustomBlock.BlockID => BlockID;
		public string Name => "SmileyBlock";
		public string Description => "A block that provides a POV camera, somehow";
		public FactionSubTypes Faction => FactionSubTypes.GSO;
		public BlockCategories Category => BlockCategories.Accessories;
		public GameObject Prefab { get; }
		public Sprite DisplaySprite { get; } = new SpriteFactory().CreateSprite(SpriteFile);
		
		public SmileyBlock()
		{
			GameObject obj = new GameObject();
			GameObject.DontDestroyOnLoad(obj);
			obj.name = Name;
			obj.tag = "TankBlock";
			obj.layer = Globals.inst.layerTank;
			
			Visible vis = obj.EnsureComponent<Visible>();
			vis.m_ItemType = new ItemTypeInfo(ObjectTypes.Block, BlockID);
			
			Damageable dmg = obj.EnsureComponent<Damageable>();
			ModuleDamage modDamage = obj.EnsureComponent<ModuleDamage>();
			AutoSpriteRenderer spriteRenderer = obj.EnsureComponent<AutoSpriteRenderer>();
			obj.EnsureComponent<TankBlock>();
			TankBlock tankBlock = obj.GetComponent<TankBlock>();
			
			tankBlock.m_BlockCategory = Category;
			tankBlock.attachPoints = new Vector3[]{
				new Vector3(0, 0, 0.5f), //Top
				new Vector3(0, 0, -0.5f), //Bottom
				//new Vector3(0, 0.5f, 0), //Front
				new Vector3(0, -0.5f, 0), //Back
				new Vector3(0.5f, 0, 0), //Left
				new Vector3(-0.5f, 0, 0), //Right
			};
			tankBlock.filledCells = new Vector3[]{ new Vector3(0, 0, 0) };
			tankBlock.partialCells = new Vector3[]{ };
				
			GameObject renderObject = new GameObject();
			renderObject.transform.parent = obj.transform;
			renderObject.name = $"{Name}.Model";
			renderObject.layer = Globals.inst.layerTank;
			
			MeshRenderer renderer = renderObject.EnsureComponent<MeshRenderer>();
			renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
			
			MeshFilter filter = renderObject.EnsureComponent<MeshFilter>();
			
			if (!File.Exists(MyFirstBlockFile))
			{
				File.WriteAllText(MyFirstBlockFile, MyFirstBlockData);
			}
			filter.mesh = new ObjImporter().ImportFile(MyFirstBlockFile);
			
			Vector3 bounds = filter.mesh.bounds.size;
			float largestSide = Mathf.Max(bounds.x, bounds.y, bounds.z, 1f);
			float scale = 1f / largestSide;
			renderObject.transform.localScale = new Vector3(scale, scale, scale);
			
			BoxCollider collider = renderObject.EnsureComponent<BoxCollider>();
			collider.center = Vector3.zero;
			collider.size = new Vector3(largestSide,largestSide,largestSide);
			
			// Create a new 1x1 texture ARGB32 (32 bit with alpha) and no mipmaps
			Texture2D texture = new Texture2D(1, 1, TextureFormat.ARGB32, false);

			// set the pixel values
			texture.SetPixel(0, 0, Color.white);
			//texture.SetPixel(1, 0, Color.white);
			//texture.SetPixel(0, 1, Color.white);
			//texture.SetPixel(1, 1, Color.white);

			// Apply all SetPixel calls
			texture.Apply();

			// connect texture to material of GameObject this script is attached to
			renderer.material.mainTexture = texture;
			
			Prefab = obj;
		}
	}
}
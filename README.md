# yt26-git-workshop

雲科大「現代遊戲程式開發技巧」工作坊：版本控制那一段的練習用 repo。

## 這是範例資料夾，不是完整 Unity 專案

repo 裡只有 `Assets/GitDemo/` 這個資料夾與它的 `.meta`，
不含 `ProjectSettings`、`Packages/manifest.json`、`Library`，所以在 Unity 裡開不了。

用起來是兩步：

1. 用 Fork 把這份 repo clone 到自己要的資料夾（例如 `~/workshop/yt26-git-workshop`）。
2. 建一個空的 Unity 專案（例如 `~/workshop/MyGame`），
   把 `yt26-git-workshop/Assets/GitDemo` 整個複製進 `MyGame/Assets/` 底下。

之後在 Inspector 看數值、切開關，都在 `MyGame` 裡做。
要比較分支上的另一個版本，就在 Fork 切分支，再把 `GitDemo` 重新複製進 `MyGame/Assets/` 一次。
（這一步在課堂上的實際感受要實測。）

**clone 完先別開 Unity。**先在 Fork 裡把 repo 檢查過一遍再開：
Unity 一開過就會自己產生 `.meta`，到那個時候才發現少了什麼，已經來不及了。

## Unity 版本

設計上只用 Unity 2022 以上都有的功能：`ScriptableObject` 資料檔與一般 C# 腳本。
**預計相容 Unity 2022.3 與 6.3，尚未實測**：這份 repo 還沒在 Unity 裡開過一次，
真正開過之前，這裡不寫「測過」。

## 專案裡有什麼

| 檔案 | 在做什麼 |
|---|---|
| `Scripts/EnemyData.cs` | 敵人數值的資料類別 |
| `Data/Enemy.asset`、`Data/Boss.asset` | 一般敵人和魔王的數值 |
| `Scripts/WaveData.cs`、`Data/Wave.asset` | 每一波出多少敵人 |
| `Scripts/RulesData.cs`、`Data/Rules.asset` | 生命數、時間上限 |
| `Scripts/DropData.cs`、`Data/DropTable.asset` | 掉東西的機率 |
| `Scripts/EnemyController.cs` | 讀資料檔裡的速度移動 |

幾個數值的合理範圍（超出來玩起來就不對）：

- 敵人對玩家的移動速度：3 到 8
- 掉東西的機率：0 到 1

## 這份 repo 的歷史是刻意排的

提交歷史、標籤與分支都是練習的一部分，裡面埋了幾個要你自己找出來的問題。
線索在 Fork 的歷史與差異裡，不在 README 裡。

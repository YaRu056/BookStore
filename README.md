# BookStore

>## 設計動機

1. 通識課使用過一次的課本想出售給需要的人
2. 班上負責訂書的同學可方便統計管理
3. 必修課有非本班的同學也可以透過此系統訂購書籍

>## 設計目的 

每個人都可以訂購書籍，讓書本發揮他最大的價值，而不是塵封在書櫃，也方便訂購者統一管理。

>## 設計流程

1. 使用者買書賣書介面設計
2. 屏大書城”平台整體架構設計
3. 登入介面設計和使用者資料建立
4. 新增或刪除欲賣出或欲購買的書籍
5. 買賣書籍使用XML檔整合
6. 使用者登入整合
7. 統整與修改

>## 成果說明

  一開始進入登入畫面，可以選擇按鈕1.註冊紐或是2.登入紐，若沒有帳密選擇註冊紐，註冊成功以後會將資料寫入資料庫MySql(xampp模擬)，註冊成功後關閉註冊的視窗，回到登入的頁面，若輸入的帳密在資料庫搜尋符合資料，便會成功登入，進到本系統後右上角會記錄你的ID左邊有菜單欄可供選擇功能(目前提供的功能有Home,Sell Book,Shopping List)，選擇功能會呈現相對應的畫面。

  * Home(買書):
  
    搜尋欄位輸入你想購買的書籍名稱，下方會呈現搜尋結果，點選想買的書籍再點選order按鈕，下方會呈現已購買的書籍資料以及目前的消費金額，若在賣家未處理訂單前皆可取消，最後點選Sure按鈕，便可在Shopping List中找到你所訂購的書籍。買家的帳號為登入的ID。
  
  * Shopping List(購買清單):
  
    可看到所購賣的書籍，若訂單未處理可點選cancel按鈕，來取消訂單。
  
  * Sell Books(販賣書籍):
  
    輸入書籍資料以及圖片後，按下+Add按鈕便會寫進記憶體中，下方會呈現新增的資料，確定以後便可按下Update的按鈕寫入xml檔。若有買家帳號可以藉由右下方的下拉式選單來更改訂單的處理狀況。賣家的帳號和賣家名稱為註冊時的設定。

  * 資料庫環境:
  
    ![image](https://user-images.githubusercontent.com/82867224/134695037-da0bd236-3400-4a17-97f9-94b9caa26d6f.png)

>## 結論:

做的這個專案，有些功能不太齊全，像是其實還可以在加上聯絡方式和加到我的最愛等等功能...目前資料那些無法上傳資料到網路，還有就是最後無法完成在賣書和購買清單中只呈現個人帳號的功能。在使用者登入上，帳號的資料內容，註冊後便不可再編輯，也不太像一般的登入系統如果忘記密碼可以給予提示、或更改的功能，這些都是我們能再精進的部分。不過，此系統能讓每人都可透過此平台買賣書籍，附有搜尋關鍵字功能可上傳圖片，但目前無法做出刪除圖片，再來就是我們也做出較為精美的介面，也算是有做出比較不一樣的功能。透過這次專案，讓我們了解使用一個小程式，其中果然是要耗費不少的功夫，若能精進自己的程式，做起來想必會容易一些。



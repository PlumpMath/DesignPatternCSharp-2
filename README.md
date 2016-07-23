# DesignPatternCSharp

[デザインパターン | TECHSCORE(テックスコア)](http://www.techscore.com/tech/DesignPattern/index.html/)の写経（Ｃ＃版)

## メモ
### 1. Iterator パターン
Aggregate と Ｉｔｅｒａｔｏr は対で作成する

### 2. Adapter パターン
継承と委譲の２種類がある
- Class Adapter パターン(継承を利用：ホワイトボックスの再利用)
- Object Adapter パターン（合成を使って委譲：ブラックボックスの再利用）



### 3. TemplateMethodパターン
スーパークラスで処理の枠組みを定める

### 4. FactoryMethod パターン
インスタンスの生成をサブクラスに行わせる

### 5. Singleton パターン
コンストラクタを private に

### 6. Prototype パターン
複製を作成するためのメソッドを用意する

### 7. Builder パターン
Director ：作成過程
Builder：表現形式

### 8. AbstractFactory パターン
抽象的なFactory クラスを利用することで、利用するオブジェクトを入れ替えることができる

[Factory Method パターンとの違い](https://ja.wikipedia.org/wiki/Abstract_Factory_%E3%83%91%E3%82%BF%E3%83%BC%E3%83%B3#Factory_Method_.E3.83.91.E3.82.BF.E3.83.BC.E3.83.B3.E3.81.A8.E3.81.AE.E9.81.95.E3.81.84)

# 仕様について

OscPortScoket を使った OSC の送受信の実装方法は、サンプルを確認して頂ければわかると思います。

## OscPortScokect

- OnReceive に任意に実装したメソッドを登録すると、受信時に通知される仕組みです。
  - ReceiveMode が Event のときは受信時に通知、Poll のときはポーリング(定期的に確認しに行く)です。
- Local Port は受信時に利用するポート番号を設定します。
- Remote Host には、送信先のアドレスを指定します。
- Remote Port には、送信先のポート番号を指定します。
- Limit Receive Buffer にはバッファサイズを設定します。

## ポート番号が衝突するとき

ポート番号が衝突するなどの問題で起動できないとき、OscPortSocket は無効になります。
エラーが発生しますがメッセージが通知されない点に注意します。
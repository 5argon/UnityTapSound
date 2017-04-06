# UnityTapSound

Tap the screen then it will sound. A simple project to test the audio latency.
It is a part of [this research about audio latency](http://exceed7.com/mobile-native-audio/research.html).

## How it works

- If you touch **down** the screen will turns red (touch registered). This is by checking for `Input` in `Update`.
- And it will also play a sound with `audioSource.Play()`

## Expected behaviour

- On iOS the screen turns red very fast. On Android it is a bit late.
- On both iOS and Android the sound comes very late, as opposed from instantly if you tried it in the editor. (You need to add mouse event)

# Spotify-Stream-Widget
A small Tool for Streamers to show the current Track of Spotify to your Viewers! Completly customizable to fit your style.

# Spotify destroyed this tool :(
Sorry, but this tool is not working at the moment. I try to find out how I can bring the tool back to work. Maybe you can help. On the 19th July 2018 Spotify published an update which kills the local control of Spotify. My tool used this control to get the current playback info. Here is Spotify's offical response:

> Remote control of Spotify’s desktop app has been deprecated in favour of full track playback in the browser. 
[https://developer.spotify.com/community/news/2018/07/19/new-updates-to-spotify-play-button/](https://developer.spotify.com/community/news/2018/07/19/new-updates-to-spotify-play-button/)

So they are two options now:
 1. I can try to use the Web API which means that the user need a internet connection, third party tracks will not be recognized and the user will need to authentificat the application to get access to his current track infos.
 2. Try to get the infos from the System Media Transport Controls (I will now call it SMTC) which means that I could get all the necessary playback data from any audio player which also use the SMTC. The problem is that the SMTC is not made for getting data. You can only send data to it. Maybe I will find a solution for it.

_Meanwhile, I'm improving the readability of the code so others can understand it better and maybe can help me with that problem. That would be great!_


## Screenshots
![alt text](https://github.com/MarcoPNS/Spotify-Stream-Widget/blob/master/img/screen.jpg?raw=true "Screenshot")
![alt text](https://github.com/MarcoPNS/Spotify-Stream-Widget/blob/master/img/2018-04-14%2012_05_32-.jpg?raw=true "Screenshot")
![alt text](https://github.com/MarcoPNS/Spotify-Stream-Widget/blob/master/img/screen2.jpg?raw=true "Screenshot")

## [Download this Tool now!](https://github.com/MarcoPNS/Spotify-Stream-Widget/releases)

## How to use it?
1. Download the tool
2. Please make sure that Spotify is running on the Computer and the SpotifyWebHelper is activated.
3. Start the Tool
4. Customize the Viewer and open the Viewer
5. Now you can add the window "Spotify Viewer" on your Stream using OBS, XSplit or similiar.

## Donate
PayPal: [https://www.paypal.me/MarcoSadowski](https://www.paypal.me/MarcoSadowski)

Dogecoin: [D9Amrvp3sGvk9aBepRtiGuZJgHV2zFaYZh](https://dogechain.info/address/D9Amrvp3sGvk9aBepRtiGuZJgHV2zFaYZh)
Such wow! Much amaze!

## Troubleshooting

### SpotifyWebHelper isn't running!
To activate the Web Helper you need to go to the settings, go to the advanced settings and then you need to activate "Allow Spotify to be opened from the web"
![alt text](https://github.com/MarcoPNS/Spotify-Stream-Widget/blob/master/img/2018-04-14%2010_57_43-Spotify.jpg?raw=true "Screenshot")

Restart Spotify and then it should work.

## Credits
Made by [Marco Sadowski](https://twitter.com/MarcoSadowski)

This application use [Metroframework by Dennis Magno](https://github.com/dennismagno/metroframework-modern-ui) and [SpotifyAPI-NET by Jonas Dellinger](https://github.com/JohnnyCrazy/SpotifyAPI-NET)

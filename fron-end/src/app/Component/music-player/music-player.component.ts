import { Component, OnInit } from '@angular/core';
import { Track } from 'ngx-audio-player';
@Component({
  selector: 'app-music-player',
  templateUrl: './music-player.component.html',
  styleUrls: ['./music-player.component.css']
})
export class MusicPlayerComponent implements OnInit {

onTrackPlaying(event:any) {
    console.log(event);
    // your logic which needs to
    // be triggered once the
    // track ends goes here.
}


onTrackPaused(event:any) {
    console.log(event);
    // your logic which needs to
    // be triggered once the
    // track ends goes here.
}

onEnded(event:any) {
    console.log(event);
    // your logic which needs to
    // be triggered once the
    // track ends goes here.
}

onNextTrackRequested(event:any) {
    console.log(event);
    // your logic which needs to
    // be triggered once the
    // track ends goes here.
}


onPreviousTrackRequested(event: any) {
    console.log(event);
    // your logic which needs to
    // be triggered once the
    // track ends goes here.
}

onTrackSelected(event:any) {
    console.log(event);
    // your logic which needs to
    // be triggered once the
    // track ends goes here.
}
  mssapDisplayTitle = true;
  mssapDisablePositionSlider = true;
  mssapDisplayRepeatControls = true;
  mssapDisplayVolumeControls = true;
  mssapDisplayVolumeSlider = false;
  mssapPlaylist: Track[] = [];


  ngOnInit(){

     this.mssapPlaylist=[
    {
      title: 'Patient Zero',
      link: 'https://music.youtube.com/watch?v=jCYnLYuGunM&si=Y6o08cEtsxHd4-ch',
      mediaType: 'stream'
      },
      {
      title: 'Megalo',
      link: 'https://music.youtube.com/watch?v=02PN62j-GAA&si=2xaItwlwRPbNyXvk',
      mediaType: 'stream'
      },
      {
      title: 'Deep in The Night',
      link: 'https://music.youtube.com/watch?v=5onuMsu3-CA&si=fJLMiJslQymipXGY',
      mediaType: 'stream'
    }
    ];
  }
}


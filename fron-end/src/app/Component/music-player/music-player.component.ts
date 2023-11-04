import { Component } from '@angular/core';
import { Track } from 'ngx-audio-player';
@Component({
  selector: 'app-music-player',
  templateUrl: './music-player.component.html',
  styleUrls: ['./music-player.component.css']
})
export class MusicPlayerComponent {

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


    mssapPlaylist: Track[] = [
    {
      title: 'Audio Title',
      link: 'Link to Streaming URL',
      mediaType: 'stream'
      },
      {
      title: 'Audio Title',
      link: 'Link to Streaming URL',
      mediaType: 'stream'
      },
      {
      title: 'Audio Title',
      link: 'Link to Streaming URL',
      mediaType: 'stream'
    }
    ];

}


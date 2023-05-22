let Record = {

    MediaRecorder: {},
    Init: () => {
        let _that = this
        if (navigator.mediaDevices.getUserMedia) {
            const constraints = { audio: true }

            navigator.mediaDevices.getUserMedia(constraints).then(stream => {
                console.info("授权成功");

                _that.MediaRecorder = new MediaRecorder(stream)

            }, ()=>{
                console.info("授权失败")
            })
        }
    },

    OnRecord: () => {
        if (this.MediaRecorder.state === "recording") {
            this.MediaRecorder.stop();
            console.info("录音结束");
        } else {
            this.MediaRecorder.start();
            console.info("录音中...");
        }
        console.log("录音器状态：", this.MediaRecorder.state);
    },

    RecordListener: ()=>{
        return MediaRecorder.ondataavailable = (e)=>{
            return e.data
        }
    }
}
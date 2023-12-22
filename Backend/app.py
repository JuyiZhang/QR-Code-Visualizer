from flask import Flask
import json

app = Flask(__name__)

@app.route("/")
def home():
	return version()

@app.route("/version")
def version():
    return "0.0.1:221220231619"

@app.route("/qr_test")
def qr_test():
    qr_result = {
        "title": "Hello World",
        "caption": "This field is used to test out the content included in the qrcode and shall be replaced in the future with actual test. For right now, just sit back and enjoy the content. Good luck! ;)"
    }
    return(json.dumps(qr_result))

# encoding:utf-8
import requests 

# client_id 为官网获取的AK， client_secret 为官网获取的SK
AK=	"TMzd1puRxGNsd6FqjakXazLg"
SK="jqUvSg8tLLx40ycveemI1KujLKsieAZH"
host = 'https://aip.baidubce.com/oauth/2.0/token?grant_type=client_credentials&client_id='+AK+'&client_secret='+SK
response = requests.get(host)
if response:
    print(response.json())
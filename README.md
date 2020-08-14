# unity通过TUIO协议连接星秒雷达pavo
***
## 1.产品样式  
### 非工作状态(指示灯不亮)  
![siminics](https://jp-github.oss-cn-shenzhen.aliyuncs.com/unity-tuio-pavo/siminics.jpg)
### 工作状态(两个指示灯全亮)
![working](https://jp-github.oss-cn-shenzhen.aliyuncs.com/unity-tuio-pavo/working.jpg)
***
## 2.安装PavoView
### 进入[星秒官网](http://www.siminics.com/Surport/List)下载，步骤如下图所示
![downloadSDK](https://jp-github.oss-cn-shenzhen.aliyuncs.com/unity-tuio-pavo/downloadSDK.jpg)
![downloadPavoView](https://jp-github.oss-cn-shenzhen.aliyuncs.com/unity-tuio-pavo/downloadPavoView.jpg)
### 找到![PavoView](https://jp-github.oss-cn-shenzhen.aliyuncs.com/unity-tuio-pavo/PavoView.jpg)，并运行之。
***
## 3.运行安装PavoView
### 根据[PavoView使用指南-V1.2.1.5](https://jp-github.oss-cn-shenzhen.aliyuncs.com/unity-tuio-pavo/PavoView%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97-V1.2.1.5.pdf)进行配置  
### 正常情况应该会出现点云图，如下图所示  
![point](https://jp-github.oss-cn-shenzhen.aliyuncs.com/unity-tuio-pavo/point.jpg)
***
## 4.运行lesstouch
### 该软件需要激活码激活，但是以下连接提供试用版，如需解锁该软件，请联系星秒销售人员。 
### [百度云盘链接](https://pan.baidu.com/s/1P8730OHuwwGbn8mpchM93A) 提取码：cpgl
### 根据文件里面的 `LessTouch简易使用说明.docx` 进行操作
### 注意：运行 `lesstouch` 的时候一定要先把 `PavoView` 关掉。
***
## 5.运行unity
### 一切都按照docx文档配置好后，接下来开始TUIO输出，然后打开unity工程文件
### 运行结果应当如下  
![handMove](https://jp-github.oss-cn-shenzhen.aliyuncs.com/unity-tuio-pavo/handMove.gif)  
![pointMove](https://jp-github.oss-cn-shenzhen.aliyuncs.com/unity-tuio-pavo/pointMove.gif)




# FlvMerger
drag and drop multi-file into dialog, and merge flv file


透過拖拉的方式合併 flv 檔案(需相同編碼)


FLV 檔案構成
----------
FLV 檔案 = FLV表頭檔+ tag1 + tag內容1 + tag2 + tag內容2 + ...+... + tagN+tag內容N

download
---------
https://github.com/wwssllabcd/FlvMerger/blob/master/FlvMerger/obj/Debug/FlvMerger.exe


FLV 表頭檔：（9位元組）
----------
	1. 
		* 1-3：前3個位元組是檔案格式標識（FLV 0x46 0x4C 0x56）。
		* 4-4：第4個位元組是版本（0x01）
		* 5-5：第5個位元組的前5個bit是保留的必須是0.
		* 
			* 第5個位元組的第6個bit音訊類型標誌（TypeFlagsAudio）
			* 第5個位元組的第7個bit也是保留的必須是0
			* 第5個位元組的第8個bit影片類型標誌（TypeFlagsVideo）

		* 6-9: 第6-9的四個位元組還是保留的。其資料為00000009 .
		* 整個檔案頭的長度，一般是9（3+1+1+4）


tag 基本格式: 固定長度為 15 位元組
----------
	* 1-4：前一個tag長度（4位元組），第一個tag就是0
	* 5-5：tag類型（1位元組）；0x8音訊；0x9影片；0x12指令碼資料
	* 6-8：tag內容大小（3位元組）
	* 9-11：時間戳（3位元組，毫秒）（第1個tag的時候總是為0,如果是指令碼tag就是0）
	* 12-12：時間戳擴充功能（1位元組）讓時間戳變成4位元組（以儲存更長時間的flv時間資訊），本位元組作為時間戳的最高位。
	* 13-15：streamID（3位元組）總是0


byte 15 格式
----------
* videoCodeID = bit0~3
* soundType = Bit0
* soundsize = bit1
* soundRate = bit2,3
* soundFormat = bit4~7;

Others
----------
1. tag or data 都有可能會沒寫完, 例如寫tag寫到一半就沒了, 或是data寫到一半就沒了 
2. 在flv回放過程中，播放順序是按照tag的時間戳順序播放。任何加入到檔案中時間設定資料格式都將被忽略。

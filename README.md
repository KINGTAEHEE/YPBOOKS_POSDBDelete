# YPBOOKS_POSDBDelete
영풍문고 POS 거래건 중 조건에 맞는 거래건을 POS 서버 DB에서 삭제해주는 프로그램.


![프로그램 실행시](https://github.com/KINGTAEHEE/YPBOOKS_POSDBDelete/blob/main/POSDBDelete-1%20v1.1.png)


거래건 조건 중 하나라도 빠진 조건이 있을 시 "조건값이 올바르지 않음" 알림창을 띄워 삭제가 진행되지 않는다.


![조건값 오류시](https://github.com/KINGTAEHEE/YPBOOKS_POSDBDelete/blob/main/POSDBDelete-2.PNG)


쿼리를 보낼때 조건으로 입력받은 값들을 올바른 데이터 타입으로 변환하여 보내기 때문에 처리 속도가 빠르다.


![삭제 완료시](https://github.com/KINGTAEHEE/YPBOOKS_POSDBDelete/blob/main/POSDBDelete-3.PNG)


**소스 코드 중 주요 정보는 * 문자로 대체.**


[UPDATE LOG]


v1.1
1. 영수증 번호로 삭제 기능 추가
2. 조건으로 삭제 시 유효성 검사 보충

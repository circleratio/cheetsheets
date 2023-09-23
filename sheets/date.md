---
title: date
---
- 日付のゼロ埋めを外す: date '+%-m/%-d
- 曜日の取得: date +%w
  - 0が日曜日。
- 基準日からX日後: date --date '1 days ago 2023-08-01'
- 月末: date '+%Y-%m-%d' --date "1 days ago $(date '+%Y-%m-01' --date '1 months')"
  - 月末は月によって違うので、「翌月初日の前日」で求める

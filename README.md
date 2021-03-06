# Custom Views On Android

This talk is about custom views in the sense of compound views and 
custom views which implement `OnDraw`. It aims to describe how to 
debug layout performance issues and how to be a good citizen in the `OnDraw`
method.

In short terms:

- Don't nest layouts
- Be careful with expensive layouts such as RelativeLayout, LinearLayout and GridLayout
  - ConstraintLayout is the new kid on the block
- Reuse paints, paths etc in `OnDraw`
- Be quick in `OnDraw`; less than 16 ms

# License

Unless stated in the header of the file, the files in this repository are licensed under the MIT License.
See [LICENSE](https://github.com/Cheesebaron/android-layout-perf/blob/master/LICENSE) 

# Snowboarder
Snowboarder is a Unity game that lets you do unique movements with a snowboard in a cozy atmosphere as a special character.

**My Experiences**
  In my recent project, The Snowboarder, I explored and implemented various new techniques to enhance gameplay and overall experience. For the first time, I utilized Level Sprite Shape, significantly improving the game's level design and allowing more creative flexibility.

To ensure smooth character movement, I integrated Unity's Surface Effector component within my character script, which made the snowboard glide realistically over snow surfaces. Additionally, by using Cinemachine Brain, I achieved dynamic camera control that smoothly follows the player, maintaining them in the frame’s center and adding a cinematic feel to the gameplay.

Sound design played a crucial role in increasing immersion. I implemented distinct sound effects for critical events, such as crashing and crossing the finish line. The CrashDetector script effectively pauses player control upon collision, triggers particle effects, plays crash sounds, and restarts the level after a brief interval using coroutines.

For improved player interaction, I incorporated torque-based rotation mechanics, enabling fluent and engaging snowboard maneuvers. The DustTrail script was particularly challenging, as it dynamically activates a realistic snow-trail effect when the snowboard contacts the snow surface.

Finally, the FinishLine script signals level completion through audio cues and particle effects, subsequently restarting the game after a short delay.

This project significantly expanded my technical skills and understanding of game mechanics, equipping me with valuable experience I look forward to applying in future game development endeavors.

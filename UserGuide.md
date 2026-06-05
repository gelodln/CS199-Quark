# Quark — User Manual

Quark is an Augmented Reality physics learning app for Grade 6 students. An *instructor* builds
a physics activity, shares it as an *access code*, and *learners* redeem the code to play it —
or free-build in a sandbox. Quark has *four physics modules* (Gravity, Friction, Energy
Transformation, Simple Machines) each available in *three modes* (Instructor Build, Learner
Play, Learner Build).

**Note on screenshots/video:** placeholders marked `[SCREENSHOT: …]` and `[CLIP: …]` indicate
the image/video to capture on a real device. The video shot list + narration is in §8. Replace
bracketed button/label names with the exact on-screen text where it differs.


---

## 1. Before you start

- *Device:* an Android device (8.0+) with a working camera and AR support.
- *Image target:* print the Quark marker (provided with the app). Use a flat, non-glossy
  printout in good, even lighting. The AR play space anchors onto this marker.
- *Account:* an email and password. Instructors and learners use different account roles.
- *Internet:* required for sign-in, saving, sharing, and loading activities.

---

## 2. Signing in

1. Launch *Quark*. The start screen appears.
2. *New user?* Tap *Sign Up*, enter your email + password, and confirm.
3. *Returning user?* Enter your credentials and tap *Log In*.
4. After signing in you land on your *Dashboard* — Instructor or Learner depending on your
   account.
5. To sign out, use the *Log Out* control on the dashboard.

If login fails, check your email/password and internet connection.


---

## 3. Aiming at the AR marker (all modes)

Every module scene works the same way in AR:

1. Open a module scene (see §4–§6).
2. Point the camera at the *printed marker*. The play space (platform + objects) appears
   anchored on top of it.
3. Keep the marker in view while you work. If the marker leaves the frame, **the simulation
   freezes** and objects can't be moved — re-aim at the marker to continue. Your objects are not
   lost.
4. You can move around the marker to view the scene from different angles; the play space stays
   upright.

---

## 4. Instructor — build & share an activity

### 4.1 Open an Instructor Build scene

From the Instructor Dashboard, open a module in *Instructor Build* (e.g. *Gravity — Instructor
Build*). The full toolbar is available: *Save*, *Load*, *Share*, *Reset*, *Settings*.

### 4.2 Build the scene

1. *Spawn objects* using the module HUD (e.g. tap an object/prefab button).
2. *Move / rotate / scale* an object: tap to select it, then drag, twist, or pinch.
3. *Adjust physics* with the module's sliders/toggles (e.g. gravity strength, air resistance,
   friction surface). The simulation updates live.
4. Use *Reset* to clear the scene and start over.

(Module-specific controls are listed in §7.)

### 4.3 Save the activity

Tap *Save Activity*. Your scene is stored to your account. Only you (the owner) can overwrite it.

### 4.4 Share via access code

1. Tap *Share Activity*. Quark publishes the activity and generates a short *access code*.
2. The *Share overlay* displays the code.
3. Give this code to your learners (write it on the board, message it, etc.).

---

## 5. Learner — redeem a code & play

### 5.1 Add an activity by access code

1. On the Learner Dashboard, find the *access code* field.
2. Type the code from your instructor and tap *Confirm/Add*.
3. The activity is added to your list. (An invalid or expired code shows
   "Invalid or Expired Code".)

### 5.2 Play the activity

1. Open the added activity (it loads in *Learner Play*). The instructor's exact setup appears.
2. Interact with the objects and try to reach the activity's goal. You *cannot* edit or
   overwrite the instructor's activity.
3. When you complete the goal, your *result/score* is recorded; you can view your metrics.

---

## 6. Learner — free build (sandbox)

From the Learner Dashboard, open a module in *Learner Build*. This is a free sandbox: spawn and
play with objects and parameters. There is *no Save or Share* here — it's for exploration.

---

## 7. The Four Physics Modules
### 7.1 Gravity
Drop, throw, and fling objects under platform-aligned gravity. Controls: *gravity strength*
slider, *air resistance* toggle, *throw arrow* for launching. Watch how mass/air resistance
change the motion.

### 7.2 Friction
Build a tile map of different *surfaces* (e.g. ice, asphalt, wood). Push objects and compare how
far they slide on each surface. Includes goal tiles, spikes, and fall edges.

### 7.3 Energy Transformation
Connect an energy *source* through *tiles* to a *sink* (e.g. Battery→Light, Sun→Plant). A
complete chain activates; a broken chain disables what's downstream. Move through the *stages*
and confirm each.

### 7.4 Simple Machines
Spawn levers, ramps, pulleys, gears, and seesaws. Set object *weight*, *apply force*, and
*reset*. Explore mechanical advantage.

---

## 8. Video demo — shot list & narration script

Record each segment with screen capture (Android: built-in recorder or scrcpy; for AR shots,
also film the device pointed at the marker). Keep each clip 20–60 s. Suggested running order for a
single ~5-minute demo, or split into the labelled clips.

| # | Clip | What to show on screen | Narration (read aloud) |
|---|------|------------------------|------------------------|
| 1 | *Intro* | App icon → launch → start screen | "Quark is an augmented-reality physics app for Grade 6. Let's see how it works." |
| 2 | *Sign in* | Sign up, then log in to instructor account | "First, sign in. Instructors and learners each get their own dashboard." |
| 3 | *AR marker* | Point camera at printed marker; play space appears | "Quark anchors the play space onto a printed marker. Keep it in view." |
| 4 | *Instructor build* | Spawn objects, move/scale, adjust a slider | "As an instructor, I build an activity — spawn objects and set the physics." |
| 5 | *Save* | Tap Save Activity → confirmation | "I save the activity to my account." |
| 6 | *Share* | Tap Share → access code appears in overlay | "Sharing publishes it and gives me an access code for my class." |
| 7 | *Learner redeem* | Switch to learner account → enter code → Confirm | "A learner enters that code to add the activity." |
| 8 | *Learner play* | Open activity → instructor's setup loads → interact → reach goal | "They open it in Play mode — my exact setup — and try to solve it. Their score is recorded." |
| 9 | *Free build* | Learner Build sandbox | "Learners can also free-build in a sandbox to explore on their own." |
| 10 | *Modules montage* | Quick cut through Gravity, Friction, Energy, Simple Machines | "Quark covers four topics: gravity, friction, energy transformation, and simple machines." |
| 11 | *Tracking lost* | Move marker out of frame → simulation freezes → re-aim → resumes | "If the marker leaves view the simulation pauses safely, and resumes when you re-aim." |
| 12 | *Outro* | Return to dashboard | "That's Quark — build, share, and play physics in AR." |

*Recording tips*
- Do a silent screen-record first, then add narration in editing if reading live is awkward.
- For AR clips, a second phone/camera filming the device + marker shows the physical setup clearly;
  cut between that and the screen capture.
- Capture the *access code legibly* in clip 6 (zoom/hold).
- Keep one continuous take of the full instructor→learner loop (clips 4–8) so reviewers see it's
  real end-to-end.

---

## 9. Troubleshooting

| Problem | Fix |
|---------|-----|
| Camera is black / AR won't start | Grant camera permission; ensure the app's Vuforia license is configured (see Installation Guide). |
| Play space doesn't appear | Improve lighting; use a flat, non-glossy printout; fill more of the frame with the marker. |
| Objects frozen / can't move | The marker is out of view — re-aim at it. |
| "Invalid or Expired Code" | Re-check the code with the instructor; ask them to Share again. |
| Can't save as a learner | By design — only the instructor (owner) can save/share an activity. |
| Login fails | Verify email/password and internet connection. |

---

### Screenshot capture checklist (hand to whoever records)

Capture, on a real device, with real button text:
- [ ] Startup/login, Sign Up
- [ ] Instructor dashboard, Learner dashboard
- [ ] Instructor Build scene (full toolbar), spawn menu, parameter panel
- [ ] Save confirmation, *Share overlay with access code*
- [ ] Learner dashboard access-code field, activity added, Learner Play loaded, results window
- [ ] Learner Build sandbox
- [ ] Each of the 4 module HUDs
- [ ] Printed marker; play space anchored on marker

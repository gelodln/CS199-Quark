# Quark - Installation & Setup Guide

Two parts: *A. Run the app* and *B. Set up the backend* it connects to.

---

## What you need

- *Unity 2022.3.62f3* (install via Unity Hub, with *Android Build Support*).
- *Git* to clone the project.
- A free *Vuforia* account (for the AR license key).
- A free *Supabase* account, plus the *Supabase CLI* (for the backend).
- An *Android phone* (8.0+, with a camera) and a *printed image target*.

Keep ~10–15 GB free - Unity builds a large cache on first open. You will have to sacrifice a lot of storage space for this project.

---

## A. Run the app

1. *Clone the project* and open the folder in Unity Hub with version *2022.3.62f3*.
   The first open is slow while Unity imports everything - let it finish.

2. *Add your Vuforia key.* In Unity: *Window → Vuforia Configuration*, and paste your
   *App License Key* (how to get one is in B-2). Without it, the AR camera won't start.

3. *Point the app at your backend.* Search the code for supabase.co and sb_publishable
   and replace them with your own Supabase *project URL* and *anon key* (from B-1).

4. *Run it.*
   - In the Editor: press *Play* to test login, menus, and the modules.
   - On a phone: *File → Build Settings → Android → Build And Run* with the phone connected.

5. *Print the image target* (flat, non-glossy, good contrast), open a module, and point the
   camera at it - the scene anchors to the marker.

---

## B. Set up the backend (Supabase)

### B-1. Create the project
Make a project at *supabase.com*. Copy its *Project URL* and *anon key* into the app
(step A-3). Under *Authentication → Providers*, turn on *Email* login.

### B-2. Get the Vuforia key
At *developer.vuforia.com*: *License Manager → Get Development Key*, then copy the key into
Unity (step A-2).

### B-3. Create the two tables
In the Supabase SQL editor, run:

-- Activities built by instructors
create table public.scene (
  scene_id     uuid primary key default gen_random_uuid(),
  owner_id     uuid not null references auth.users(id),
  title        text,
  description  text,
  scene_data   jsonb,
  is_published boolean default false,
  access_code  text,
  created_at   timestamptz default now(),
  updated_at   timestamptz default now()
);

-- Activities a learner has unlocked with a code
create table public.learner_collection (
  learner_id uuid not null references auth.users(id),
  scene_id   uuid not null references public.scene(scene_id),
  added_at   timestamptz default now(),
  primary key (learner_id, scene_id)
);

Turn on *Row Level Security* for both tables, then add rules so that only an activity's owner
can change it, and learners can only see activities they've unlocked or that are published.

### B-4. Deploy the backend functions
Set the secrets, then deploy:

supabase secrets set SUPABASE_URL=<your-url> SUPABASE_ANON_KEY=<anon-key> SUPABASE_SERVICE_ROLE_KEY=<service-role-key>

supabase functions deploy save-scene-state
supabase functions deploy get-scene-state

The app also calls three functions for sharing activities by code - one to publish a scene and
return a code, one to unlock a scene from a code, and one to list a learner's unlocked scenes.
Create these in your project following the same pattern as the two above.

---

## C. Quick check

1. *Sign up*, log out, and log back in.
2. As an *instructor*: build an activity, *Save*, then *Share* - a code should appear.
3. As a *learner* (second account): *Add* that code and open the activity - the objects load.

If those work, the app and backend are connected correctly.

---

## D. If something breaks

- *Weird compile/package errors* → wrong Unity version. Use exactly *2022.3.62f3*.
- *Black camera / "no license"* → Vuforia key not pasted, or the database isn't activated.
- *Marker won't track* → glossy or low-contrast print, dim light, or a creased page.
- *Login/permission errors from the backend* → expired login, or you're not the activity's owner.
